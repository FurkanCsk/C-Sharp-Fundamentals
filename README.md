# C# Fundamentals

Proje haftasına hoş geldiniz! Bu projede sizlerden 3 aşamalı bir uygulama geliştirmeniz isteniyor. Uygulamayı çalıştıran kullanıcıya program seçeneklerini konsol üzerinden sunarak bir tanesini seçmesini isteyiniz.

Hangi programı çalıştırmak istersiniz - 3 farklı seçenek :

1 - Rastgele Sayı Bulma Oyunu

2 - Hesap Makinesi

3 - Ortalama Hesaplama
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Rastgele Sayı Bulma Oyunu

Bilgisayar bir rastgele sayı belirlesin (örneğin 1 ile 100 arasında).

Kullanıcıdan bu sayıyı tahmin etmesini isteyin.

Kullanıcı her tahmininde, bilgisayarın seçtiği sayıya yakınlığını kontrol edin ve ipucu verin (daha yüksek veya daha düşük).

Kullanıcının 5 canı olsun (5 tahmin hakkı). Her tahmin sonrası kalan canını gösterin.

Kullanıcı doğru tahminde bulunursa oyunu bitirin ve tebrik edin.

Eğer 5 tahmin hakkı dolarsa, doğru sayıyı gösterin ve oyunu bitirin.

![image](https://github.com/user-attachments/assets/1445313b-9a15-452e-97df-d0b95d6acf85)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Hesap Makinesi

Kullanıcıya ilk sayıyı girmesini isteyin.

Kullanıcıya ikinci sayıyı girmesini isteyin.

Kullanıcıya yapmak istediği işlemi seçmesini isteyin:

Toplama için +

Çıkarma için -

Çarpma için *

Bölme için /

Kullanıcının seçimine göre uygun işlemi gerçekleştirip sonucu ekrana yazdırın. Eğer bölme işlemi seçildiyse, sıfıra bölme hatası durumunu kontrol edin.

Programı yazarken dikkat etmeniz gereken noktalar:

Kullanıcı girdilerini doğru bir şekilde almak için Console.ReadLine() ve Convert.ToInt32() gibi metodları kullanın.

İşlem seçiminde if-else veya switch-case yapısını kullanarak uygun işlemi gerçekleştirin.

Bölme işlemi yapılırken sıfıra bölme hatasını kontrol edin ve kullanıcıya uygun bir mesaj gösterin.

![image](https://github.com/user-attachments/assets/e5aa8226-0774-42af-a13c-f3dc29ecad89)
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Ortalama Hesaplama

Kullanıcıdan birinci ders notunu girmesini isteyin.

Kullanıcıdan ikinci ders notunu girmesini isteyin.

Kullanıcıdan üçüncü ders notunu girmesini isteyin.

Girdiği notların ortalamasını hesaplayın ve ekrana yazdırın.

Notların geçerli olup olmadığını kontrol edin (0-100 aralığında olmalıdır). Geçersiz bir not girildiğinde kullanıcıya hata mesajı verin ve programı sonlandırın.

Ortalama notun harf karşılığını göstermek için aşağıdaki harf notu tablosunu kullanın:

90-100: AA
85-89:  BA
80-84:  BB
75-79:  CB
70-74:  CC
65-69:  DC
60-64:  DD
55-59:  FD
0-54:   FF
Programı yazarken dikkat etmeniz gereken noktalar:

Kullanıcı girdilerini doğru bir şekilde almak için Console.ReadLine() ve Convert.ToDouble() gibi metodları kullanın.

Notların geçerliliğini kontrol etmek için if yapısını kullanın.

Ortalama hesaplamasını doğru bir şekilde yapmak için double türünde bir değişken kullanın.

Harf notu tablosunu kullanarak kullanıcının aldığı ortalamaya karşılık gelen harf notunu belirleyin ve ekrana yazdırın.

![image](https://github.com/user-attachments/assets/52d6d32a-c0c4-43de-b21e-92c0544e83eb)
