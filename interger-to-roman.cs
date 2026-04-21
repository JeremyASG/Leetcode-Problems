public class Solution {
    // Ejercicio #12
    public string IntToRoman(int num) {
        
        int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] simbolos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        
        StringBuilder resultado = new StringBuilder();
        
        for (int i = 0; i < valores.Length; i++)
        {
            while (num >= valores[i])
            {
                resultado.Append(simbolos[i]);
                num -= valores[i];
            }
        }
        
        return resultado.ToString();
    }
}