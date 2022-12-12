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

//boolean 

bool b1 = 10<2 ;

// değilken Dönüşümler 

string str20 = "20";
int int20 = 20 ;
string yeniDeger =str20 + int20.ToString();
Console.WriteLine(yeniDeger);


// int dönüşümler 

int int21 = int20 + Convert.ToInt32(str20) ; 
Console.WriteLine(int21) ;


string nebu = DateTime.Now ("mm");
Console.WriteLine(nebu);










