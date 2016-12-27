
import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URL;
import java.net.URLConnection;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.util.ArrayList;
import javax.json.Json;
import javax.json.JsonArray;
import javax.json.JsonObject;
import javax.json.JsonReader;
import javax.json.JsonValue;

public class HRDownloader {


	public static void main(String[] args) {

		
		
		/*********************************/
		// SETTINGS
		/*********************************/
		//Edit these
		//make sure the directories exist beforehand!
		String masterFileLocal = "c:/jsondownload/mainSubmissionFile.json";
		String localDownloadDirectory = "c:/jsondownload/";
		int msBetweenHttpDownloads = 500;
		String cookieSession = "debb3712819715d5373d6932010399392385488dddj233j2j3838";
		
		//Hackerrank.com specific
		//no need to edit unless they change their REST API
		String submissionBaseUrl = "https://www.hackerrank.com/rest/contests/master/submissions/";
		String masterFileUrl = "https://www.hackerrank.com/rest/hackers/me/recent_activity?offset=0&limit=1000";
		String cookieName = "_hrank_session";
		String cookieString = cookieName + "=" + cookieSession;
		/*************************/

		
		//Note: if you get an http 405 error then your session is invalid
		
		
		/*********************************/
		// CODE
		/*********************************/
		
		// Download Main Submissions File
		outputText("Downloading main submission JSON file");
		downloadPage(masterFileUrl, masterFileLocal, cookieString);
		
		// Parse Main Submissions File
		outputText("Parsing  main submission json file");
		ArrayList<String> itemsToDownload = parseMainJsonFile(masterFileLocal);
		outputText("Found "+itemsToDownload.size()+" submissions");
		
		// Download Submission Files
		outputText("Downloading submissions...");
		downloadSubmissions(itemsToDownload, localDownloadDirectory, submissionBaseUrl, cookieString,msBetweenHttpDownloads);
		
	}
	
	
	public static void downloadSubmissions(ArrayList<String> itemsToDownload, String localDownloadDirectory,
			String submissionBaseUrl, String cookieString, int msBetweenHttpDownloads) {
		try {
			for (int i = 0; i < itemsToDownload.size(); i++) {

				String downloadNumber = itemsToDownload.get(i);
				String directory = localDownloadDirectory + downloadNumber + ".json";
				String stringUrl = submissionBaseUrl + downloadNumber;
				downloadPage(stringUrl, directory, cookieString);
				Thread.sleep(msBetweenHttpDownloads);

			}
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}

	public static void outputText(String message) {
		System.out.println(message);
	}

	public static ArrayList<String> parseMainJsonFile(String fileName) {
		ArrayList<String> returnList = new ArrayList<>();
		FileInputStream inputFile = null;

		try {
			inputFile = new FileInputStream(fileName);
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}

		JsonReader rdr = Json.createReader(inputFile);
		JsonObject obj = rdr.readObject();
		JsonArray results = obj.getJsonArray("models");

		for (JsonObject result : results.getValuesAs(JsonObject.class)) {
			String currentString = String.valueOf(result.getOrDefault("id", JsonValue.NULL));
			returnList.add(currentString);
			//outputText("Parsed submission id: " + currentString);
		}

		return returnList;
	}

	public static void saveFile(String file, String fileString) throws IOException {
		outputText("Local file was saved: " + file);
		Files.write(Paths.get(file), fileString.getBytes(), StandardOpenOption.CREATE);
	}
	public static void downloadPage(String urlString, String file, String cookieString) {

		URL url;
		try {
			url = new URL(urlString);

			URLConnection connection = url.openConnection();
			connection.setRequestProperty("Cookie", cookieString);
			connection.connect();

			BufferedReader pageBuffer = new BufferedReader(new InputStreamReader(connection.getInputStream()));
			String inputLine;
			String fileString = "";
			while ((inputLine = pageBuffer.readLine()) != null) {
				fileString += inputLine;
			}

			pageBuffer.close();
			saveFile(file, fileString);

		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	
	

}
