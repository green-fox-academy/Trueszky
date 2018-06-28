#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void help();


int main()
{
    char readline[20];
    float a,b;
    char *sign;
    help();
    while (1)
    {
        int counter=0;
        gets(readline);
        if (strstr(readline,"exit"))
        {
           break;
        }
        else if (strstr(readline,"help"))
        {
            help();
        }
        else if (strstr(readline,"clear"))
        {
            system("clear");
        }
        else
        {
            for (char *p = strtok(readline, " "); p != NULL; p = strtok(NULL, " "))
            {
                if (atoi(p) > 0)
                {
                    if (counter == 0)
                    {
                        a = atoi(p);
                    }
                    else
                    {
                        b = atoi(p);
                    }
                     counter++;
                }
                else
                {
                    sign = p;
                }
            }
        }
        printf("%.2f %s %.4f \n",a,sign,b);
    }

    return 0;
}
void help()
{
    char sztring[50];
    FILE *path = fopen("help.txt","r");
    while (fgets(sztring,50,path)!=NULL)
    {
        printf("%s",sztring);
    }
    printf("\n");
}
void Getter()
{

}

