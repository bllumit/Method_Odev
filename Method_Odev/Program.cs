
// todo: isPalindrome metodu ile cümle içerisindeki palindrome kelimleri bulup palindroms dizine ekleyen programı yazınız...
class Program
{

    static void Main(string[] args)
    {
        string cumle = "bu gün hava çok güzel arkadaşlar ile pinkik yapmaya gittik orada kavak ağaçları vardı çıkmadan önce elbiselerime ütü yaptım";
        
        string[] kelime = cumle.Split(' ');
        string[] palindroms = new string[0];
        foreach (var item in kelime)
        {
            char[] klm = item.ToCharArray();
            Array.Reverse(klm);
            bool isPalindrom;

            if (item == new string(klm))
                isPalindrom = true;
            else
                isPalindrom = false;

            if (isPalindrom)
                for (int i = 0; i < kelime.Length; i++)
                {
                    Array.Resize(ref palindroms, palindroms.Length + 1);
                    palindroms[palindroms.Length -1] = item;
                    break;
                }
        }
        // palindrome kelimleri yazdıralım...
        foreach (var item in palindroms)
        {
            Console.WriteLine(item);
        }
    }

    //BURDA TIKANDIM.....Mantığını kuramadım bir türlü.

    //static bool IsPalindrome(string kelime)
    //{
    //    bool isp; // geçici true değeri verdik. 
    //    if (isPalindrome)
    //        isp = true;
    //    else
    //        isp = false;
    //    return isp;

    //    // eğer kelime palindromesa isp true, değilse false atanmalı

    //    return isp; // ispi dön.
    //}
}