using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    internal class CharacterStack
    {
        private char[] stack; //Array of elements
        private int size;    //maximum number of elements in stack
        private int top;     //index of top element in the stack.

        public CharacterStack(int n)  //n is the maximum size of stack.
        {
            size = n;
            stack = new char[size]; //allocate space to array of size n
            top = -1;              // No elements in the stack initially.
        }
       public bool isEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool isFull()
        {
            if (top==size-1)
                return true;
            else 
                return false;
        }
        public void push(char element)
        {
            if (isFull())
                Console.WriteLine("Stack OverFlow!");
            else
            {
                top++;
                stack[top] = element;
            }
        }
        public char pop() 
        { 
            if(isEmpty())
            {
                Console.WriteLine("Stack Underflow!!");
                return default(char);
            }
            else
            {
                char element = stack[top];
                top--;
                return element;
            }   
        }
        public char peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack Empty");
                return '\0';
            }                
            else
                return stack[top];
        }
        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Stack is empty");
            else
            {
                Console.WriteLine("The elements of Stack are: ");
                for (int i = top; i >= 0; i--)                
                    Console.WriteLine(stack[i]);                
            }
        }
    }
}
