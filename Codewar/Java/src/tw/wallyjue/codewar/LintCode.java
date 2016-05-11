package tw.wallyjue.codewar;

public class LintCode {
	public boolean anagram( String s , String t){
		if(s == null || t == null){
			return false;
		}
		if(s.length() != t.length()){
			return false;
		}
		for(int i = 0; i < s.length();i++){
			for(int j = 0; j < t.length();j++){
				if(s.charAt(i) != t.charAt(j)){
					return false;
				}
			}
			
		}
		
		return true;
	}
}
