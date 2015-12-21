

public class Test(){
    
    
    private string url="";
    
    HttpWebRequest requst=new (HttpWebRequest)HttpWebRequest.Create(this.url);
    request.ContentType="application/json";
    
    byte[] postDataByte=Encoding.UTF-8.GetBytes(data);
    
    request.ContentLength=postDataByte.Length;
    
    Stream streamRequest;
    streamRequest=request.GetRequestStream();
    streamRequest.Write(postDataByte,0,postDataByte.Length);
    streamRequest.Close();
    
    HttpWebResponse response=(HttpWebResponse)request.GetResponse();
    
    Stream streamResponse=response.GetResponseStream();
    
    StreamReader streamReader=new streamReader(streamResponse);
    
    string resultResponse=streamReader.ReadToEnd();
    
}