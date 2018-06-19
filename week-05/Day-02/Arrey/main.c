#include <stdio.h>
#include <stdlib.h>

int main()
{
        // - Create an array variable named `q`
        //   with the following content: `[4, 5, 6, 7]`
        // - Print the third element of `q`

        int q[]={4,5,6,7};
        printf("%i \n\n",q[2]);

        // - Create an array variable named `p1`
        //   with the following content: `[1, 2, 3]`
        // - Create an array variable named `p2`
        //   with the following content: `[4, 5]`
        // - Print if `p2` has more elements than `p1`

        int p1[]={1,2,3};
        int p2[]={4,5};
        if (sizeof(p1)/sizeof(p1[0])<sizeof(p2)/sizeof(p2[0]))
            {
                printf("p2 has more elements\n\n");
            }
            printf("p2 has no more...\n\n");


        // - Create an array variable named `r`
        //   with the following content: `[54, 23, 66, 12]`
        // - Print the sum of the second and the third element

        int r[]={54,23,66,12};
        printf("%i \n\n",r[1]+r[2]);


        // - Create an array variable named `s`
        //   with the following content: `[1, 2, 3, 8, 5, 6]`
        // - Change the 8 to 4
        // - Print the fourth element

        int s[]={1,2,3,8,5,6};
        s[3]=4;
        printf("%i \n\n",s[3]);


        //- Create an array variable named `t`
        //  with the following content: `[1, 2, 3, 4, 5]`
        //- Increment the third element
        //- Print the third element

        int t[]={1,2,3,4,5};
        t[2]++;
        printf("%i \n\n",t[2]);


        // - Create an array variable named `numbers`
        //   with the following content: `[4, 5, 6, 7]`
        // - Print all the elements of `numbers`

        int numbers[]={4,5,6,7};
        int i=0;
        while (sizeof(numbers)/sizeof(numbers[0])>i)
            {
                printf("%i \n",numbers[i]);
                i++;
            }
        printf("\n\n");


        // - Create (dynamically) a two dimensional array
        //   with the following matrix. Use a loop!
        //
        //   1 0 0 0
        //   0 1 0 0
        //   0 0 1 0
        //   0 0 0 1
        //
        // - Print this two dimensional array to the output

        int k,j;
        for (k=0;k<4;k++)
            {
                for (j=0;j<4;j++)
                    {
                        if (k==j)
                            {
                                printf("%i ",1);
                            }
                        printf("%i ",0);
                    }
                    printf("\n");
            }





        return 0;
}
