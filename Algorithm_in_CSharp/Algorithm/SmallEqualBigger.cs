using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithm
{
    internal class SmallEqualBigger
    {
        public static Node listPatition(Node head, int pivot)
        {
            Node sH = null; // small head
            Node sT = null; // small tail
            Node eH = null; // equal head
            Node eT = null; // equal tail
            Node mH = null; // big head
            Node mT = null; // big tail
            Node next = null; // save next node

            // every node distributed to three lists
            while(head != null)
            {
                next = head.next;
                head.next = null;
                if(head.value < pivot)
                {
                    if(sH == null)
                    {
                        sH = head;
                        sT = head;
                    }
                    else
                    {
                        sT.next = head;
                        sT = head;
                    }
                }
                else if (head.value == pivot)
                {
                    if(eH == null)
                    {
                        eH = head;
                        eT = head;
                    }
                    else
                    {
                        eT.next = head;
                        eT = head;
                    }
                }
                else
                {
                    if(mH == null)
                    {
                        mH = head;
                        mT = head;
                    }
                    else
                    {
                        mT.next = head;
                        mT = head;
                    }
                }
                head = next;
            }

            // small and equal reconnect
            if(sT != null)
            {
                sT.next = eH;
                eT = eT == null ? sT : eT;
            }

            // 上面的if， 不管跑了没有， et
            // all reconnect
            if(eT != null)
            {
                eT.next = mH;
            }
            return sH != null ? sH : (eH != null ? eT : mH);
        }
    }
}
