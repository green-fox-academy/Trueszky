#include <stdio.h>
#include <stdlib.h>

int main()
{
    double massInKg = 81.2;
    double heightInM = 1.78;
    double bmi= massInKg/(heightInM*heightInM);

    // Print the Body mass index (BMI) based on these values
    printf("%.2f \n",bmi);
}
