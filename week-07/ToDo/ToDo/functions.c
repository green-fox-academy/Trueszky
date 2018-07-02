#include "functions.h"

void commands()
{
    FILE *path = fopen("commands.txt","r");
    while(fgets(sztring,50,path)!=NULL) {
        printf("%s",sztring);
    }
    printf("\n");
    fclose(path);
}
static void  l_command()
{
    i=0;
    FILE *tasks = fopen("tasklist.txt","r");
    if(tasks==NULL) {
        printf("No todolist, it's lost... :(\n");
    }
    else if(tasks!=NULL) {
        fseek(tasks,0,SEEK_END);
        if(0==ftell(tasks)) {
            puts("No todos for today! :)");
        }
        fseek(tasks,0,SEEK_SET);

        while(fgets(sztring,50,tasks)!=NULL) {
                printf("%d.\t%s",i,sztring);
                i++;
        }
    }
    fclose(tasks);
    tasksize();
}
static void a_command(char *array)
{
    int j=linecounter();
    char *pch=strtok(array,"-");
    if(strlen(pch)==1) {
        puts("Append is empty");
    }
    else {
    FILE *tasks = fopen("tasklist.txt","a");
    fprintf(tasks,"%d\t%s\n",j,pch+2);
    fclose(tasks);
    }
}

static void remove_any()
{

}
static void complete_command()
{
    FILE *tasks = fopen("tasklist.txt","a");

    fclose(tasks);
}
void imputstring(char *text)
{
    if(strchr(text,'-')!=NULL) {
        char *pch=strchr(text,'-');
        input(text[pch-text+1],text);

    }
    else {
        printf("%s\n",text);
    }
}
void input(char character,char *array)
{
    if(character=='l') {
        l_command();
    }
    else if(character=='a') {
        a_command(array);
    }
    else if(character=='r') {
        remove_any();
    }
    else if(character=='c') {
        complete_command();
    }
    else if(character=='e'){
            clear_question();
    }
    else if(character=='h'){
        commands();
    }
    else if(character=='q'){
            puts("Have a Good Day");
            exit(0);
    }
}
static void clearfile()
{
    FILE *tasks = fopen("tasklist.txt","w");
    fclose(tasks);
}
void clear_question()
{
    printf("Want to deltete ToDo list? ");
    char a=getchar();
    if( a=='y') {
        clearfile();
    }
    fflush(stdin);
}
int tasksize()
{
    FILE *tasks = fopen("tasklist.txt","r");
    fseek(tasks,0,SEEK_END);
    int numofchars = ftell(tasks);
    printf("Amount of character: %d\n",numofchars);
    fclose(tasks);
    return numofchars;
}
int linecounter()
{
    FILE *tasks = fopen("tasklist.txt","r+");
    int lines=0;
    char c;
    for (c = getc(tasks); c != EOF; c = getc(tasks)) {
        if (c == '\n'){
            lines++;
        }
    }
    fclose(tasks);
    return lines;
}
void array_maker()
{
    int k = tasksize();
    int j;
    FILE *tasks = fopen("tasklist.txt","r+");
    char *tomb;
    tomb = (char *)malloc(k*sizeof(char));
    j=0;
    for(j=0;feof(tasks)!=NULL;j++) {
        tomb[j]=fgetc(tasks);
    }
    j=0;
    while(tomb[j]!='\n') {
        printf("%c",tomb[j]);
        j++;
    }
    free(tomb);
}
