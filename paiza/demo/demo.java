import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.nio.file.Files;
import java.nio.file.Paths;

public class demo {
    public static void main(String args[] ) throws Exception {
        boolean isStdIO = true;
        if( args.length > 0){
            isStdIO = false;
        }

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        if( isStdIO == true){
            String line = br.readLine();
            /*
                read the input here and do handling
            */
        }else{
            /*
                read the input here and do handling
            */
            for (String line : Files.readAllLines(Paths.get("inputfile.txt"))) {
                System.out.println("line:"+ line);
            }
        }
    }
}
