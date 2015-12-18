最近在一个MVC5项目中遇到了一个问题：C#编码规范中规定属性的首字母是大写的（大多数公司采用这种编码风格），但是从其它系统中接收到的json对象的属性却是小写的（大多数公司采用这种编码风格），怎样才能方便地完成转换？

　　最笨的方法是定义一个所有属性名为小写的ViewModel类，然后再编写相应的方法来完成大小写属性的转换。

   有没有更加优雅的做法？

　　在MVC5，默认的json序列化组件是Newtonsoft.Json。怎样才能让Newtonsoft.Json在序列化的时候自动将大写转换成小写，而在反序列化的时候自动转换成大写？查找文档之后，发现使用JsonPropertyAtrribute即可。要使用JsonPropertyAtrribute，需要先引用命名空间Newtonsoft.Json。如下所示：
```

 using Newtonsoft.Json;

　　/// <summary>
　　///    
 　　/// </summary>
   public class Product
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        [JsonProperty("productId")]
        public string ProductId { set; get; }


        /// <summary>
        /// 商品名称
        /// </summary>
       [JsonProperty("productName")]
       public string ProductName { set; get; }
       
       public string productCode

 }

```

在代码中，我们使用[JsonProperty("productId ")]来修饰ProductId属性，productId为小写，ProductId为大写。在序列化和反序列的时候，Newtonsoft.Json会自动进行转换。


　