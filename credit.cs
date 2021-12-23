#include <stdio.h>
#include <cs50.h>
#include <math.h>
int main(void)
{
    int kartTipi = 0;
    long Kart; 
    do
    {
        Kart = get_long("Kart numarınızı giriniz: "); 
    }
    while (Kart < 0); 
    long kontrol = Kart;

    while (kontrol > 0)
    {
        kontrol = kontrol / 10;  
        kartTipi++; 
    }
    if (kartTipi != 15 && kartTipi != 13 && kartTipi != 16) 
    {
        printf("Geçersiz\n");
        return 1;
    }
    long MC = Kart / 100000000000000;
    long AMEXP = Kart / 10000000000000;    
    long Visa = Kart / 1000000000000000; 
    if (kartTipi == 15)
    {
        if (AMEXP != 34 && AMEXP != 37)    {
            printf("Geçersiz\n");
            return 1;
        }
        else
        {
            printf("AMEXP\n");
            return 0;
        }
    }

    if (kartTipi == 16)
    {
        if (MC == 51 || MC == 52 || MC == 53 || MC == 54 || MC == 55)  
        {
            printf("MASTERCARD\n");
            return 0;
        }
        else if (Visa == 4)  
        {
            printf("VISA\n");
            return 0;
        }
        else if (MC != 51 && MC != 52 && MC != 53 && MC != 54 && MC != 55 && Visa == 4)
        {
            printf("Geçersiz\n");
            return 1;
        }
    }

    if (kartTipi == 13 && Visa == 4)  
    {
        printf("VISA\n");
        return 0;
    }
    else if (kartTipi != 13 && Visa != 4)
    {
        printf("Geçersiz\n");
        return 1;
    }

}
