package hackerRank.algo.warmup;

import java.util.regex.*;

public class TimeConvertion {
	public static String timeConversion(String s) {
        // Complete this function
		String ret = "";
		String pattern = "^([0-1]?\\d|2[0-3]):([0-5]?\\d):([0-5]?\\d)(PM|AM)$";
		Pattern r = Pattern.compile(pattern);
		Matcher m = r.matcher(s);
		if (m.find()) {
			if(m.group(4).contains("AM")){
				if(Integer.parseInt(m.group(1)) == 12) {
					ret = "00:"+m.group(2)+":"+m.group(3);
				}
				else {
					ret = m.group(1)+":"+m.group(2)+":"+m.group(3);
				}
			}
			else {
				//PM
				if(Integer.parseInt(m.group(1)) == 12) {
					ret = "12:"+m.group(2)+":"+m.group(3);
				}
				else {
					ret = (Integer.parseInt(m.group(1))+12)+":"+m.group(2)+":"+m.group(3);
				}
			}
			
		}
		return ret;
    }
}
