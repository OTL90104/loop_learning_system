using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_learning_system
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            String start_article = "0";
            String article_out = "a";
            String temp;

            while (start)
            {
                Console.WriteLine("請問要進入哪個單元?輸入1-->while，輸入2-->do while，輸入3-->for，輸入q離開");
                start_article = Console.ReadLine();

                #region 單元一
                if (start_article == "1")
                {
                    start_article = "0";
                    article_out = "0";
                    while (article_out != "q")
                    {
                        temp = "0";
                        Console.Clear();
                        Console.WriteLine(@"
<單元一> While(重複敘述)

重複結構，會依據一個條件，這條件成立的情況下，會一直持續執行某一個動作，
當條件不滿足的時候才會跳出這個重複結構，否則就會一直重複下去。

＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠
＠　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　＠
＠　　int product = 10;　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　while ( product <= 1000 )　　　　　　　　　　　　　　　　　　　 ＠
＠　　{　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　　　Console.WriteLine(""There are"" + product + ""items."");        ＠
＠　　　　product = product * 2;　　　　　　　　　　　　　　　　　　　＠
＠　　}　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　＠
＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠

比如說：如果我們所有的商品小於1000件的話，我就把商品數量乘以兩倍；
我們可以發現在這個while結構當中他body裡的敘述跟之前選擇結構不一樣的地方在於，
while結構內的敘述在執行時必然會去修改條件的判斷情況，
譬如說在這個例子中，每一次重複的時候，我會增加商品數量為原本的兩倍。
因為如果我們沒有在body裡面去改變條件的判斷情況，這個結構將會不斷執行下去，造成所謂的無窮迴圈。
while loop會一直重複直到條件判斷式的結果不成立的時候，
所以在這個例子裡，當商品數量增加的總數大於或等於1000的時，這個重複結構便會停止執行。");
                        Console.WriteLine("\n輸入q離開");
                        temp = Console.ReadLine();
                        if (temp == "")
                        {
                            article_out = "a";
                        }
                        else if (temp == "q")
                        {
                            Console.Clear();
                            article_out = "q";
                            start_article = "0";
                        }
                        else
                        {
                            Console.WriteLine("不行喔~要輸入q才給你離開~");
                            article_out = "a";
                        }
                    }
                }
                #endregion
                #region 單元二
                else if (start_article == "2")
                {
                    start_article = "0";
                    article_out = "0";
                    while (article_out != "q")
                    {
                        temp = "0";
                        Console.Clear();
                        Console.WriteLine(@"
<單元二> Do....while (重複敘述)

do…while敘述是另一種重複結構，和while迴圈的結構相當相似。
差別在於它條件判斷是放在body之後；

＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠
＠　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　＠
＠　　int product = 10;　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　do　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　  ＠
＠　　{　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　　　Console.WriteLine(""There are"" + product + ""items.""); 　     ＠
＠　　　　product = product * 2;　　　　　　　　　　　　　　　　　　　＠
＠　　}while(product <= 1000);　　　　　　　　　　　　　　　　　　　　＠
＠　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　＠
＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠

換句話說，迴圈的內容至少會執行過一次，
執行過後在判斷迴圈內容，檢驗是否要再繼續重複一次。
另外，與其他重複結構不同的地方是，在do…while的結尾一定要加分號；
如果沒有加，將會產生編譯錯誤。
");
                        Console.WriteLine("\n輸入q離開");
                        temp = Console.ReadLine();
                        if (temp == "")
                        {
                            article_out = "a";
                        }
                        else if (temp == "q")
                        {
                            Console.Clear();
                            article_out = "q";
                            start_article = "0";
                        }
                        else
                        {
                            Console.WriteLine("不行喔~要輸入q才給你離開~");
                            article_out = "a";
                        }
                    }
                }
                #endregion
                #region 單元三
                else if (start_article == "3")
                {
                    start_article = "0";
                    article_out = "0";

                    while (article_out != "q")
                    {
                        temp = "0";
                        Console.Clear();
                        Console.WriteLine(@"
<單元三> For (重複敘述)

將計數器控制重複結構所需要的三個元素用一行表達

我們先來看看while的寫法：

＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠
＠　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　＠
＠　　int counter = 1;　　　　　　　　　　　　　　　　　　　　　　　  ＠
＠　　while(counter <= 10)　　　　　　　　　　　　　　　　　　　　　  ＠
＠　　{　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　　　Console.WriteLine(counter);　　　　　　　　　　　　　 　 　 ＠
＠　　　　counter++　　　　　　;　　　　　　　　　　　　　　　　　　　＠
＠　　}　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　＠
＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠

在來看看使用for迴圈的寫法：

＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠
＠　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　＠
＠　　for(int counter = 0; counter <= 10; counter++)　　　　　　　　　＠　　　　　　　　　　　　　　 
＠　　{　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　　　Console.WriteLine(counter);　　　　　　　　　　　　　 　 　 ＠
＠　　}　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　 ＠
＠　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　＠
＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠

首先宣告一個控制變數counter，for迴圈中一開始時便將它初始化為1，
再來是迴圈判斷的條件，當這個控制變數小於或等於10，就會繼續執行迴圈當中的內容，
最後在每次執行結束後，對此控制變數做累加，也可以遞減，
如果要累加的數值不一樣時，就直接寫在第三個部份，
而這個範例只是把它單純+1，所以用一個++即可，記得每個部份之間必須用分號隔開。
特別注意，假如這個控制變數是宣告在for迴圈裡，那只有在這個大括號以內才能使用，
超過這個範圍的部份就無法使用這個控制變數。
");
                        Console.WriteLine("\n輸入q離開");
                        temp = Console.ReadLine();
                        if (temp == "")
                        {
                            article_out = "a";
                        }
                        else
                        if (temp == "q")
                        {
                            Console.Clear();
                            article_out = "q";
                            start_article = "0";
                        }
                        else
                        {
                            Console.WriteLine("不行喔~要輸入q才給你離開~");
                            article_out = "a";
                        }
                    }
                }
                #endregion

                else if (start_article == "q")
                {
                    start = false;
                }

                else
                {
                    Console.WriteLine("不行喔~要輸入q才給你離開~");
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

