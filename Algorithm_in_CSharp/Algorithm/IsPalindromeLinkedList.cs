using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithm
{
    public class Node
    {
        public int value;
        public Node next;

        public Node(int data)
        {
            this.value = data;
        }
    }
    internal class IsPalindromeLinkedList
    {
        // need n extra space
        public static Boolean isPalindrome1(Node head)
        {
            Stack<Node> stack = new Stack<Node>();
            Node cur = head;
            while(cur != null)
            {
                stack.Push(cur);
                cur = cur.next;
            }
            while(head != null)
            {
                if(head.value != stack.Pop().value)
                {
                    return false;
                }
                head = head.next;
            }
            return true;
        }

        // need n/2 extra space
        public static Boolean isPalindrome2(Node head)
        {
            if(head == null || head.next == null)
            {
                return true;
            }
            Node right = head.next;
            Node cur = head;
            while(cur.next != null && cur.next.next != null)
            {
                right = right.next;
                cur = cur.next.next;
            }
            Stack<Node> stack = new Stack<Node>();
            while(right != null)
            {
                stack.Push(right);
                right = right.next;
            }
            while(stack.Count != 0)
            {
                if(head.value != stack.Pop().value)
                {
                    return false;
                }
                head = head.next;
            }
            return true;
        }

        // need O(1) extra space
        public static Boolean isPalindrome3(Node head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            Node n1 = head;
            Node n2 = head;

            while (n2.next != null && n2.next.next != null)
            {  // find mid node}
                n1 = n1.next; // n1 -> middle
                n2 = n2.next.next; // n2 -> end
            }

            n2 = n1.next; // n2 -> right part first node
            n1.next = null; // mid.next -> null
            Node n3 = null;
            while (n2 != null) // right part convert
            {
                n3 = n2.next; // n3 -> save next node
                n2.next = n1; // next of right node convert
                n1 = n2; // n1 move
                n2 = n3; // n2 move
            }
            n3 = n1; // n3 -> save last node
            n2 = head; // n2 -> left first node
            Boolean res = true;
            while(n1 != null && n2 != null) // check panlindrome
            {
                if(n1.value != n2.value)
                {
                    res = false;
                    break;
                }
                n1 = n1.next; // left to mid
                n2 = n2.next; // right to mid
            }
            n1 = n3.next;
            n3.next = null;
            while(n1 != null) // recover list
            {
                n2 = n1.next;
                n1.next = n3;
                n3 = n1;
                n1 = n2;
            }
            return res;
        }

    }
}
