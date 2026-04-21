public class Solution {
    // Ejercicio #9
    public bool IsPalindrome(int x) {
        
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

        int reversed = 0;

        while (x > reversed) {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x /= 10;
        }

        // para números pares e impares
        return x == reversed || x == reversed / 10;
    }
}