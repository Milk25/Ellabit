﻿namespace Ellabit.Challenges
{
    public class Challenge121Burrrrrrrp : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Burrrrrrrp";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
	public  string LongBurp(int b) 
	{
		
	}
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.LongBurp(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Burrrp"",  $""returned: {sumResult}  expected: Burrrp"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.LongBurp(5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Burrrrrp"",   $""returned: {sumResult}  expected: Burrrrrp"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.LongBurp(9);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Burrrrrrrrrp"",   $""returned: {sumResult}  expected: Burrrrrrrrrp"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that returns the string ""Burp"" with the amount of ""r's"" determined by the input parameters of the function.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
LongBurp(3) ➞ ""Burrrp""

LongBurp(5) ➞ ""Burrrrrp""

LongBurp(9) ➞ ""Burrrrrrrrrp""
            </p>
        </code>
Notes
Expect num to always be >= 1.
Remember to use a capital ""B"".
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Index" }, { "Level", "2" } }; 
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
