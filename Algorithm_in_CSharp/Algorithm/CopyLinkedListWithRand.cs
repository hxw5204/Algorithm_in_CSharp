using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithm
{
    public class Node2
    {
        public int value;
        public Node2 next;
        public Node2 rand;

        public Node2(int data)
        {
            this.value = data;
        }
    }
    internal class CopyLinkedListWithRand
    {
        public static Node2 copyLinkedListWithRand(Node2 head) {
            Dictionary<Node2, Node2> map = new Dictionary<Node2, Node2>();
            Node2 cur = head;
            while(cur != null)
            {
                map.Add(cur, new Node2(cur.value));
                cur = cur.next;
            }
            cur = head;
            while(cur != null)
            {
                //cur 老
                // map.get(cur) 新
                map.GetValueOrDefault(cur).next = map.GetValueOrDefault(cur.next);
                map.GetValueOrDefault(cur).rand = map.GetValueOrDefault(cur.rand);
                cur = cur.next;
            }
            return map.GetValueOrDefault(head);
        }

        /// <summary>
        /// better space, worse time
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node2 copyLinkedListWithRandom2(Node2 head)
        {
            if(head == null)
            {
                return null;
            }
            Node2 cur = head;
            Node2 next = null;

            // copy node and link to every node
            // 1 -> 2
            // 1 -> 1' -> 2
            while( cur != null)
            {
                next = cur.next;
                cur.next = new Node2(cur.value);
                cur.next.next = next;
                cur = next;
            }
            cur = head;
            Node2 curCopy = null;

            // set copy node rand
            // 1 -> 1' -> 2 -> 2'
            while(cur != null)
            {
                next = cur.next.next;
                curCopy = cur.next;
                curCopy.rand = cur.rand != null ? cur.rand.next : null;
                cur = next;
            }
            Node2 res = head.next;
            cur = head;
            // split
            while(cur != null)
            {
                next = cur.next.next;
                curCopy = cur.next;
                cur.next = next;
                curCopy.next = next != null ? next.next : null;
                cur = next;
            }
            return res;
        }
    }
}
