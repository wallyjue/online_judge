package one;

import java.util.ArrayList;
import java.util.List;
import java.util.Stack;

public class LintCode {
	public class TreeNode {
		public int val;
		public TreeNode left, right;
		public TreeNode(int val) {
			this.val = val;
			this.left = this.right = null;
		}
	}
	public class ListNode {
		int val;
		ListNode next;
		ListNode(int x) { val = x; }
	}
	
    /**
     * @param A : A string includes Upper Case letters
     * @param B : A string includes Upper Case letter
     * @return :  if string A contains all of the characters in B return true else return false
     */
    public boolean compareStrings(String A, String B) {
        int strA[] = new int[256];
        //int strB[] = new int[256];
        for(int i = 0; i < A.length(); i++){
        	strA[A.charAt(i)]++;
        }
        for(int i = 0; i < B.length(); i++){
        	strA[B.charAt(i)]--;
        }
        for(int i = 0; i < 256; i++){
        	if(strA[i] < 0){
        		return false;
        	}
        }
        return true;
    }
	
	
	
	public ListNode removeElements(ListNode head, int val) {
	    ListNode helper = new ListNode(0);
	    helper.next = head;
	    ListNode p = helper;
	 
	    while(p.next != null){
	        if(p.next.val == val){
	            ListNode next = p.next;
	            p.next = next.next; 
	        }else{
	            p = p.next;
	        }
	    }
	 
	    return helper.next;
	}
	
	public ArrayList<Integer> preorderTraversal(TreeNode root) {
        // write your code here
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if(root == null){
        	return null;
        }
        ArrayList<Integer> ret = new ArrayList<Integer>();
        stack.push(root);
        TreeNode p = stack.pop();
        while(p != null){
        	ret.add(p.val);
        	if(p.left != null) stack.push(p.left);
        	if(p.right != null) stack.push(p.right);
        	p = stack.pop();
        }
        
        return ret;
    }
	
	
	public List<String> anagrams(String[] strs) {
		List<String> ret = new ArrayList<String>();
		boolean isPut[] = new boolean[strs.length];
		for(int i =0; i < strs.length; i++){
			for(int j = i; j < strs.length; j++){
				if(i != j){
					if(this.anagram(strs[i], strs[j])){
						if(!isPut[i]) {
							ret.add(strs[i]);
							isPut[i] = true;
						}
						if(!isPut[j]) {
							ret.add(strs[j]);
							isPut[j] = true;
						}
					}
				}
			}
		}
		return ret;
        // write your code here
    }
	
	
	
	public boolean anagram(String s, String t) {
		if(s.length() == 0 && t.length() == 0){
			return true;
		}
		if(s.length() == 0 || t.length() == 0){
			return false;
		}
		if(s.length() != t.length()){
			return false;
		}
		
		int chararr[] = new int[256];
		for(int i = 0; i < s.length(); i++){
			chararr[s.charAt(i)]++;
			chararr[t.charAt(i)]--;
		}
		for(int i =0; i < 256; i++){
			if(chararr[i] != 0){
				return false;
			}
		}
		return true;
    } 
	
	
	public int climbStairs(int n){
		if(n == 1){
			return 1;
		}else if( n == 2){
			return 2;
		}else if(n == 0){
			return 1;
		}
		int ret[] = new int[n+1];
		ret[1] = 1;
		ret[2] = 2;
		for(int i = 3 ; i < n+1; i++){
			ret[i] = ret[i-1] + ret[i-2];
		}
		return ret[n];
	}
	
	public String AddBinary(String a, String b){
		String ret = "";
		int maxlen = a.length();
		if(b.length() > maxlen){
			maxlen = b.length();
			for(int i = a.length(); i < b.length();i ++){
				a = "0" + a;
			}
		}else{
			for(int i = b.length(); i < a.length();i ++){
				b = "0" + b;
			}
		}
		char plus = '0';
		for(int i = maxlen-1; i >=0; i--){
			int total = Integer.parseInt(""+a.charAt(i))+
					Integer.parseInt(""+b.charAt(i))+
					Integer.parseInt(""+plus);
			switch(total){
				case 0:
					plus = '0';
					ret = "0"+ret;
					break;
				case 1:
					plus = '0';
					ret = "1"+ret;
					break;
				case 2:
					plus = '1';
					ret = "0"+ret;
					break;
				case 3:
					plus = '1';
					ret = "1"+ret;
					break;
			}
		}
		
		if(plus == '1'){
			ret = "1"+ret;
		}else{
			;//ret = "0"+ret;
		}
		
		return ret;
	}
	
	
	public ArrayList<ArrayList<String>> answer = new ArrayList<ArrayList<String>>();
	public void palindromePartition(String input ,int target){
		if(input == null){
			return;
		}
		
		if(input.length() == 1){
			answer.get(target).add(input);
		}
		int firstsubstring;
		String tmp = input;
		for( firstsubstring = 1; firstsubstring < input.length(); ++firstsubstring){
			tmp = input.substring(0, firstsubstring);
			if(isPalindrome(tmp)){
				if(answer.size() < firstsubstring){
					answer.add(new ArrayList<String>());
				}
				answer.get(firstsubstring-1).add(tmp);
			}
			palindromePartition(input.substring(firstsubstring, input.length()), firstsubstring-1);
		}
	}
	
	public String substringPalindrome(String input, int sublength, int start){
		
		//for(sublength = 1;sublength < input.length(); sublength++){
			for(; start < input.length(); start++){
				if(start+sublength <=input.length()){
					String tmp = input.substring(start,start+sublength);
					System.out.println(tmp+" is palindrome:"+isPalindrome(tmp));
					return tmp;
				}
			}
		//}
		return null;
	}
	
	public boolean isPalindrome(String input){
		if(input == null) return false;
		int len = input.length();
		for(int i=0 ; i< len/2; i++){
			if(input.charAt(i) != input.charAt(len-i-1)){
				return false;
			}	
		}
		return true;
	}
}
