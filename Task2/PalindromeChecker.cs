public class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        string cleaned = Regex.Replace(input, "[^a-zA-Z0-9]", "").ToLower();

        int left = 0;
        int right = cleaned.Length - 1;

        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
    
}