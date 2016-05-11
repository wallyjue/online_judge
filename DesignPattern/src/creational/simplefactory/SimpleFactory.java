package creational.simplefactory;

import creational.ObjectDAO;

public class SimpleFactory {
	public static ObjectDAO getObjectDAO(String sign){
		ObjectDAO objRet = null;
		if(sign.equals("Chang")){
			objRet = new ObjectDAO();
			objRet.setSubject("Subject of this object dao");
			objRet.setBody("This is the body of this object dao");
			objRet.setLocale("en_US");
		}
		return objRet;
	}
}
