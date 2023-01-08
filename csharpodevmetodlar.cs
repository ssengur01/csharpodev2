using System;

public class csharpodevmetodlar

{
	public static void Main()
	{
		VKIHesaplama();
	}
	static (double kilo, double boy) HastaBilgileri()
	{
		Console.Clear();
		Console.Write("Boyunuzu Giriniz (metre): ");
		double boy = Convert.ToDouble(Console.ReadLine());
        Console.Write("Kilonuzu Giriniz : ");
        double kilo = Convert.ToDouble(Console.ReadLine());

		return(boy, kilo);

    }
	static void VKIHesaplama()
	{
		var operantlar = HastaBilgileri();
		double sonuc = operantlar.boy / Math.Pow(operantlar.boy, 2);
		if (sonuc < 18.49 )
		{
            Console.WriteLine($"Hastanın; boyu: {operantlar.boy}, kilosu: {operantlar.kilo}, VKI indeksi: {sonuc}, Teşhis: ZAYIF");
        }
		else if (sonuc >= 18.5 && 24.99)
		{
            Console.WriteLine($"Hastanın; boyu: {operantlar.boy}, kilosu: {operantlar.kilo}, VKI indeksi:  {sonuc}, Teşhis: İDEAL");

        }
		else if (sonuc >= 25 &&  29.99)
		{

            Console.WriteLine("Hastanın; boyu: {0}, kilosu: {1}, VKI indeksi: {2}, Teşhis: HAFİF KİLOLU", operantlar.boy, operantlar.kilo, sonuc);
        }
		else
		{
            Console.WriteLine("Hastanın; boyu: {0}, kilosu: {1}, VKI indeksi: {2}, Teşhis: OBEZ", operantlar.boy, operantlar.kilo, sonuc);
        }
		DevamMi();
    }
	static void DevamMi()
	{
		string devamMi = "";
		Console.Write("Yeni hesaplama yapmak ister misiniz? (E/H)");
		devamMi = Console.ReadLine();
		switch (devamMi)
		{
			case "E":
			case "e":
				VKIHesaplama();
				break;
			case "H":
			case "h":
				Environment.Exit(0);
				break;
			default:
				Console.WriteLine("Hatalı giriş yaptınız");
				DevamMi();
				break; 
		}
	}
}
