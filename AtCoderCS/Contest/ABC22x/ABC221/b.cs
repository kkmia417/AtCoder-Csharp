string s  = Console.ReadLine();
string t = Console.ReadLine();

if(s == t){
    Console.WriteLine("Yes");
    return;
}

for(int i = 0; i < s.Length - 1; i++){
    char[] charArray = s.ToCharArray();
    char temp = charArray[i];
    charArray[i] = charArray[i+1];
    charArray[i+1] = temp;
    string swapped = new string(charArray);
    
    if(swapped == t){
        Console.WriteLine("Yes");
        return;
    }
}

Console.WriteLine("No");