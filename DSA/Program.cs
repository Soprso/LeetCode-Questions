using DSA;

//ReverseString obj=new ReverseString();
//string reversed = obj.stringreverse("Hello World");
//Console.WriteLine(reversed);
//AddIf a = new AddIf();

//Console.WriteLine(a.CheckAddIf("If else"));   // Output: "if else"
//Console.WriteLine(a.CheckAddIf("else"));      // Output: "if else"
////Console.ReadLine();

//RemoveCharacterAt rat = new RemoveCharacterAt();
//string res = rat.RemoveCharacterAtIndex("Python", 1);

ExchangeCharacters exc = new ExchangeCharacters();
//Console.WriteLine(exc.ExchangeFirstLast("bc"));
//Console.WriteLine(exc.CreateNewStringFromExisting("y"));
//Console.WriteLine(exc.CheckZinString("zzzz"));
//Console.WriteLine(exc.LastThreeCharUpper("js"));
//Console.WriteLine(exc.CreateCopyString("JS",2000));
//Console.WriteLine(exc.ReverseString("Hello World"));
//Console.WriteLine(exc.CreateCopySubstring("j",4));
//Console.WriteLine(exc.CountAAinString("JSaaaakoiaa"));
//Console.WriteLine(exc.MakeNewString("abcd"));
//Console.WriteLine(exc.FirstAppearance("aaaaa"));
//Console.WriteLine(exc.CompareTwoStrings("abcdefgh","abijsklm"));
//Console.WriteLine(exc.RemoveSpecificCharacter("xabjbhtrb", 'b'));
//Console.WriteLine(exc.FizzBuzz("bounder"));
//Console.WriteLine(exc.CountAlphaNumerSpecial("ghoshsoumyadeep3@gmail.com"));
//Console.WriteLine(exc.WithoutFirstandLastChar("Pythio"));
//Console.WriteLine(exc.CreateStringatGivenIndex("python",2));


//FourCopies fr = new FourCopies();
//Console.WriteLine(fr.ReturnFourCopies("a"));

//CheckTemperature ch = new CheckTemperature();
//Console.WriteLine(ch.CheckTemp(120,2));

//RangeofIntegers ri = new RangeofIntegers();
////Console.WriteLine(ri.CheckRangeOfInt(99,199));
//Console.WriteLine(ri.CheckRangeOfInt(30,30,17));

//LargestofThree largestnum = new LargestofThree();
//Console.WriteLine(largestnum.LargestofThreeNumbers(1111,4,10));

OperationonIntegers op = new OperationonIntegers();
//Console.WriteLine(op.SameLastDigit(123,456));
int[] ints = { 10, 20, -30, -40, 50 };
//Console.WriteLine(op.CheckElementPresent(ints,2));
//Console.WriteLine(op.CheckSeqPresent(ints));
//Console.WriteLine(op.CountTwoFives(ints));
//Console.WriteLine(op.IsTriplePresent(ints));
//Console.WriteLine(op.ComputeSum(2,17));
//Console.WriteLine(op.CheckIsEitherSumDiffFive(5,4));
//Console.WriteLine(op.CheckMultipleofThirteen(14));
//Console.WriteLine(op.SameRightMostDigit(ints));
//Console.WriteLine(op.ReturnSumorRightMost(10, 12, 13));
//Console.WriteLine(op.ReturnSameDifference(-1, 0, 1));
//Console.WriteLine(op.question89(ints));
//op.CubeofNumber(5);
//op.PrintRightTrianglePattern(4);
//op.PrintRightTriangleRepaeatNumber(4);
//op.PrintRightTriangleIncreasedNumber(4);
//Console.WriteLine(op.CheckNumofThreeGreaterThanFive(ints));
//Console.WriteLine(op.question126(ints));
int []res=op.ShiftElementRight(ints);
foreach (int i in res)
{
    Console.Write(i+" ");
}

