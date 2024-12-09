using System;
using TMPro;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown oper; 
    [SerializeField] private TMP_InputField op1, op2;
    [SerializeField] private TextMeshProUGUI result;

    public void calculate()
    {
        if (op1.text == "" || op2.text == "")
        {
            result.text = "Invalid Input";
            return;
        }

        int operand1 = Int32.Parse(op1.text);
        int operand2 = Int32.Parse(op2.text);

        switch (oper.value)
        {
            case 1: // Addition
                result.text = (operand1 + operand2).ToString();
                break;
            case 2: // Multiplication
                result.text = (operand1 * operand2).ToString();
                break;
            case 3: // Subtraction
                result.text = (operand1 - operand2).ToString();
                break;
            case 4: // Division
                if (operand2 == 0)
                {
                    result.text = "Cannot divide by zero";
                }
                else
                {
                    result.text = ((float)operand1 / operand2).ToString("0.##");
                }
                break;
            case 5: // Percentage (operand1 as a percentage of operand2)
                result.text = ((operand1 / (float)operand2) * 100).ToString("0.##") + "%";
                break;
            default:
                result.text = "Invalid Operation";
                break;
        }
    }
}