package one;

import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.nio.file.FileSystems;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.regex.*;

public class Mainprocess {
	
	public static void main(String[] args) {
		Path path = FileSystems.getDefault().getPath("data_set", "input.txt");
		try {
			Files.lines(path).forEach((x) -> {
				System.out.println(x);
			});
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
