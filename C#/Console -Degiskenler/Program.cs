// See https://aka.ms/new-console-template for more information
Console.WriteLine("Baba, Maraba!");
DateTime dt = DateTime.Now ;
Console.WriteLine(dt);
// string ifadeler aşagıda burası komuttan hariç türkce karakterde yazabilirim
// string te baş harf büyük olmasada olur normalde genelde büyük harf olması iyidir
string str1 = string.Empty;
str1 = "Furkan Ozt";
string ad = "Furkan";
string soyad = "Öztürk";
string tamisim = ad + " " + soyad ;

//Integer tamisim tanımlama ;
int integer1 = 5 ;
int integer2 = 3;
int integer3 = integer1 * integer2 ;

// Float 
float xcv = 2 ; // 4 byte integerla aynı yer utuyor bellekte  
float bbb = 3 ;

// Double
Double abb = 2.2 ; // decimalden daha az integerdan fazla 8
Console.Write(abb);

// ulong ul 0 dan 83 k ya kadar pozitif değerler longda - değerde bar 8 byte ama  90 k da yazdı
ulong uk = 90000 ;
long uk1 = -90000 ;
Console.WriteLine(uk); 

Console.WriteLine(uk1); 


Console.Write(xcv+bbb);


//boolean 

bool b1 = 10<2 ;
Console.WriteLine(b1);

// Degisken Dönüşümler 

string str20 = "20";
int int20 = 20 ;
string yeniDeger =str20 + int20.ToString();
Console.WriteLine(yeniDeger);


// int dönüşümler 

int int21 = int20 + Convert.ToInt32(str20) ; 
Console.WriteLine(int21) ;

// datetime

string nebu = DateTime.Now.ToString("dd.MM.yyyy");  // .ToString yaparak sondaki saat kısmını attı integerdan isdeğimiz stringleri aldık.
Console.WriteLine(nebu);










