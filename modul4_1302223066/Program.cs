using System;
using System.Net.NetworkInformation;
using static KodeBuah;
public class KodeBuah
{
    public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Kurma, Durian, Anggur, Melon, Semangka};
    public static String getKodeBuah(NamaBuah namaBuah)
    {
        string[] kodeBuah = {"A00", "B00", "C00", "D00", "E00", "K00", "L00", "M00", "N00", "O00"};
        return kodeBuah[(int)namaBuah];
    }
}

public class Main
{
    public static void MainProgram(string[] args)
    {
        string namaBuah;
        Console.WriteLine("Nama buah : Kode Buah" + getKodeBuah(namaBuah));
    }
}