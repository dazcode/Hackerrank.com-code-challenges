import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.nio.file.DirectoryStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.util.ArrayList;
import javax.json.Json;
import javax.json.JsonObject;
import javax.json.JsonReader;
import javax.json.JsonValue;

public class HRSubmissionParser {

	public static void main(String[] args) {

		/*********************************/
		// SETTINGS
		/*********************************/
		// Edit these
		String inputDirectory = "c:/jsoninput/";
		String outputDirectory = "c:/jsonoutput/";

		/*************************/

		outputText("running parser: ");
		runParser(inputDirectory, outputDirectory);

	}

	public static void runParser(String inputDirectory, String outputDirectory) {

		ArrayList<Path> jsonFilesData = null;

		try {
			jsonFilesData = getJsonSubmissionsData(inputDirectory);
		} catch (IOException e1) {
			e1.printStackTrace();
		}

		FileInputStream inputFile = null;

		outputText("jsonFilesData size: " + jsonFilesData.size());

		int acceptedCounter = 0;
		int totalCounter = jsonFilesData.size();

		for (int i = 0; i < totalCounter; i++) {

			try {
				inputFile = new FileInputStream(jsonFilesData.get(i).toString());
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			}

			JsonReader rdr = Json.createReader(inputFile);
			JsonObject obj = rdr.readObject();
			JsonObject result = obj.getJsonObject("model");

			String submissionStatus = String.valueOf(result.getOrDefault("status", JsonValue.NULL));
			String submissionCode = String.valueOf(result.getOrDefault("code", JsonValue.NULL));
			String challengeSlug = String.valueOf(result.getOrDefault("slug", JsonValue.NULL));
			String challengeID = String.valueOf(result.getOrDefault("challenge_id", JsonValue.NULL));
			String language = String.valueOf(result.getOrDefault("language", JsonValue.NULL));

			outputText("submissionStatus: " + submissionStatus);
			if (submissionStatus.equals("\"Accepted\"")) {

				String fileExtension = ".txt";

				language = language.substring(1, language.length() - 1);

				outputText("Parsed language: " + language);

				if (language.equals("php")) {
					fileExtension = ".php";
				} else if (language.equals("csharp")) {
					fileExtension = ".cs";
				} else if (language.equals("java") || language.equals("java7") || language.equals("java8")) {
					fileExtension = ".java";
				} else if (language.equals("mysql")) {
					fileExtension = ".sql";
				} else if (language.equals("cpp")) {
					fileExtension = ".cpp";
				} else if (language.equals("c")) {
					fileExtension = ".c";
				} else if (language.equals("python3")) {
					fileExtension = ".py";
				}

				challengeSlug = challengeSlug.substring(1, challengeSlug.length() - 1);
				String challengeUrl = "https://www.hackerrank.com/challenges/" + challengeSlug;

				challengeSlug = challengeSlug.replaceAll("[^A-Za-z0-9()\\[\\]]", "");
				String fileName = challengeSlug + "_" + challengeID + fileExtension;
				String file = "c:/jsonoutput/" + fileName;

				String codeCommentTop = "/*****************************\r\n";
				codeCommentTop += "Code by: David Zentner dazcode@gmail.com\r\n";
				codeCommentTop += "http://www.dazcode.com/\r\n";
				codeCommentTop += "this code is an accepted solution for code challenge located at:\r\n";
				codeCommentTop += challengeUrl + "\r\n";
				codeCommentTop += "this code may need to run in the hackerrank online ide to work correctly\r\n";
				codeCommentTop += "*****************************/\r\n";

				submissionCode = submissionCode.substring(1, submissionCode.length() - 1);
				submissionCode = submissionCode.replaceAll("\\\\\"", "\"");
				submissionCode = submissionCode.replaceAll("\\\"", "\"");
				submissionCode = submissionCode.replaceAll("\\\\t", "\t");
				submissionCode = submissionCode.replaceAll("\\\\n", "\r\n");

				submissionCode = codeCommentTop + submissionCode;

				try {
					writeCodeFile(file, submissionCode);
				} catch (IOException e) {
					e.printStackTrace();
				}

				outputText("Parsed json file: " + file);
				acceptedCounter++;
			}

			outputText("Total submission files read: " + totalCounter);
			outputText("Saved code files for " + acceptedCounter + " accepted submissions");

		}
	}

	public static void outputText(String message) {
		System.out.println(message);
	}

	public static void writeCodeFile(String file, String fileString) throws IOException {

		outputText("Local file was saved: " + file);
		Files.write(Paths.get(file), fileString.getBytes(), StandardOpenOption.CREATE);

	}

	public static ArrayList<Path> getJsonSubmissionsData(String localFileDirectory) throws IOException {

		ArrayList<Path> returnList = new ArrayList<>();

		String fileMask = "*.{json}";
		DirectoryStream<Path> stream = Files.newDirectoryStream(Paths.get(localFileDirectory), fileMask);

		for (Path entry : stream) {
			returnList.add(entry);
		}

		return returnList;
	}

}
