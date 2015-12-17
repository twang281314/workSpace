
///summary
///请求对象
///summary
public  class request
{
    ///summary
    ///出货编号
    ///summary
    public string shipmentNo{set;get;}
    
    ///summary
    ///订单编号
    ///给物流业者的客户订单编号
    ///summary
    public string orderNo{set;get;}
    
    ///summary
    ///网仓运输商
    ///summary
    public string transporterId{set;get;}
    
    ///summary
    ///网仓订单号
    ///summary
    public string orderUkid{set;get;}
    
}

///summary
///返回对象
///summary
public class response
{
    ///summary
    ///配送编号
    ///summary
    public string shipNo{set;get;}
    
    ///summary
    ///宅急便 ：宅急便距离代码
    ///新竹 ：到著站简码
    ///部分出库单按需使用
    ///summary
    public string delNo2{set;get;}
    
    ///summary
    ///宅急便 ：宅急便7码
    ///新竹 ：到著站四码
    ///部分出库单按需使用
    ///summary
    public string delNo3{set;get;}
    
    ///summary
    ///回传代码
    ///00:取号正常  10：无此单号   99：取号异常
    ///summary
    public string returntType{set;get;}
}