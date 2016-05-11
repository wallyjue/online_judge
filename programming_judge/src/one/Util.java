package one;

public class Util {
	
	  // 輸入緩衝區 (緩衝空間需要依照題目調整)
	  public static byte[] cinbuf = new byte[1024];
	 
	  // 讀取一個單字 (英文姓名包含空白時請不要用)
	  public static String readToken() {
	    int offset = 0;
	    int bytedata = -1;
	    
	    try {
	      // 略過非單字的字元 '\t','\n','\r',' '
	      bytedata = System.in.read();
	      while(bytedata==9||bytedata==10||bytedata==13||bytedata==32) {
	        bytedata = System.in.read();
	      }
	 
	      // 載入單字的字元
	      while(bytedata!=-1) {
	        if(bytedata==9||bytedata==10||bytedata==13||bytedata==32) {
	          break;
	        } else {
	          cinbuf[offset++] = (byte)bytedata;
	        }
	        bytedata = System.in.read();
	      }
	    } catch(Exception e) {}
	    
	    if(offset+bytedata==-1) return null; // 串流結束
	    return new String(cinbuf,0,offset);
	  }
	  
	  // 讀取一行
	  public static String readLine() {
	    int offset = 0;
	    int bytedata = -1;
	    
	    try {
	      // 載入整行
	      bytedata = System.in.read();
	      while(bytedata!=-1) {
	        if(bytedata==10) {
	          break;
	        } else {
	          cinbuf[offset++] = (byte)bytedata;
	        }
	        bytedata = System.in.read();
	      }
	    } catch(Exception e) {}
	 
	    if(offset+bytedata==-1) return null; // 串流結束
	    if(cinbuf[offset-1]=='\r') offset--; // window 要去除 '\r' 字元
	    return new String(cinbuf,0,offset);
	  }
	  
	  // 轉成 int 型態 (比 Integer.parseInt() 快)
	  public static int parseInt(String s) {
	    int i;
	    int mul = 10;
	    int value = s.charAt(s.length()-1)-48;
	    
	    for(i=s.length()-2;i>=0;i--) {
	      value += (s.charAt(i)-48)*mul;
	      mul *= 10;
	    }
	    
	    return value;
	  }
}
