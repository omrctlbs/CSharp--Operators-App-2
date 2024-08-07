///////////  YAŞI 18 DEN BÜYÜK YA DA VELİ İZNİ VARSA BİR İŞTE ÇALIŞABİLİR DURUMU

Console.Title = "REMOSYS";
//Console.WriteLine("Yaşınızı giriniz : ");
//int yas = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Veliniz izni var mı ? : VARSA (V) YOKSA(Y) Tuşlayınız");
//char input = Char.ToUpper(Console.ReadKey().KeyChar);
//Console.WriteLine(); 
//bool velizni;
//switch (input)
//{
//    case 'V':
//        velizni = true;
//        break;
//    case 'Y':
//        velizni = false;
//        break;
//    default:
//        Console.WriteLine("Geçerli bir seçim Yapınız");
//        return;
//}
//Console.Clear();    
//if (yas >= 18 || velizni)
//{
//    Console.WriteLine("Bir işte çalışabilirisniz ");
//}
//else
//{
//    Console.WriteLine("Bir işte çalışamazsınız. ");
//}


//DERS NOTU 50-100 ARASINDAYSA GEÇTİ DEĞİLSE KALDI BİLGİSİ YAZDIRAN PROGRAM

//Console.WriteLine("Lütfen Ders Notunuzu Giriniz : ");
//int puan = Convert.ToInt32(Console.ReadLine());

//bool kosul1 = (puan <= 50);
//bool kosul2 = (puan >= 50);
//Console.Clear();
//var sonuc = kosul1 ? "Dersi geçemediniz" : "Dersi geçtiniz";
//Console.WriteLine(sonuc);


//DERS ORTALAMASI EN AZ 70 PUAN VE ZAYIFI YOKSA TEŞEKKÜR BELGESİ ALABİLME DURUMU

//Console.WriteLine("1. Ders Notunuzu giriniz: ");
//int not1 = Convert.ToInt32(Console.ReadLine()); 
//Console.Clear();
//Console.WriteLine("2. Ders Notunuzu giriniz: ");
//int not2 = Convert.ToInt32(Console.ReadLine());
//Console.Clear();
//int notort = (not1 + not2) / 2;

//Console.WriteLine("ZAYIFINIZ VAR MI VARSA (V) YOKSA (Y)");
//char input = Char.ToUpper(Console.ReadKey().KeyChar);
//bool zayifcheck;
//switch(input)
//{
//    case 'V':
//        zayifcheck = true;
//    break;
//    case 'Y':
//        zayifcheck= false;  
//    break;
//    default:
//        Console.WriteLine("Geçerli bir seçim yapınız");
//     return;
//}
//Console.Clear();

//var sonuc = (notort >= 70 && zayifcheck);
//if (sonuc == true)
//{
//    Console.WriteLine("Tebrikler Teşekkür Belgesi Kazandınız");
//}
//else
//{
//    Console.WriteLine("Teşekkür belgesi alamadınız.");
//}

// İŞE GİRMEK İÇİN EN AZ ÖNLİSANS YA DA LİSANS MEZUNU OLMA DURUMUNU KONTROL EDİNİZ. SİGARA KULLANMAMA KOŞULU.
//Console.WriteLine("Mezun olduğunuz bölümü seçiniz : ");
//Console.WriteLine("İlkokul (I) , Lise (L), Önlisans (O), Lisans(U)");
//char input = Char.ToUpper(Console.ReadKey().KeyChar);
//bool okulcheck;
//switch (input)
//{
//    case 'I':
//        okulcheck = false;
//        break;
//    case 'L':
//        okulcheck = false;
//        break;
//    case 'O':
//        okulcheck = true;
//        break;
//    case 'U':
//        okulcheck = true;
//        break;
//    default:
//        Console.WriteLine("Geçerli bir seçim yapınız");
//        return;
//}
//Console.Clear();
//Console.WriteLine("Sigara kullanıyor musunuz : ");
//Console.WriteLine("Evet (E) Hayır (H)");
//char input1 = Char.ToUpper(Console.ReadKey().KeyChar);
//bool sigaracheck;
//switch (input1)
//{
//    case 'E':
//        sigaracheck = false;
//        break;
//    case 'H':
//        sigaracheck = true;
//        break;
//    default:
//        Console.WriteLine("Geçerli bir seçim yapınız");
//        return;
//}
//Console.Clear();
//if (sigaracheck && okulcheck)
//{
//    Console.WriteLine("Başvurunuz kabul edildi.");
//}
//else
//{
//    Console.WriteLine("Başvurunuz kabul edilmedi.");
//}


//UYGULAMAYA GİRİŞ KONTROL
//string mail = "omer.ctlbs@icloud.com";
//string id = "omrctlbs";
//int psw = 123456;

//Console.WriteLine("E-mail giriniz : ");
//string mail2 = Console.ReadLine();

//Console.WriteLine("ID giriniz : ");
//string id2 = Console.ReadLine();

//Console.WriteLine("Şifre giriniz : ");
//int psw2 = Convert.ToInt32(Console.ReadLine());
//Console.Clear();

//var sonuc = ((mail==mail2 || id == id2 ) && (psw == psw2)) ? "Giriş başarılı": "Giriş başarısız";
//Console.WriteLine(sonuc);

