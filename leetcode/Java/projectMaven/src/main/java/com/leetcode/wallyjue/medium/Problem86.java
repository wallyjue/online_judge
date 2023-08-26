package com.leetcode.wallyjue.medium;

import com.leetcode.wallyjue.ListNode;

public class Problem86 {
    public ListNode partition(ListNode head, int x) {
        ListNode fronthead = null;
        ListNode fronttail = null;
        ListNode frontrunner = null;
        ListNode rearhead = null;
        ListNode reartail = null;
        ListNode rearrunner = null;

        ListNode runner = head;
        while (runner != null)
        {
            if (runner.val >= x)
            {
                rearrunner = runner;
                if (rearhead == null)
                {
                    rearhead = rearrunner;
                }

                if (reartail != null)
                {
                    reartail.next = rearrunner;
                }
                reartail = rearrunner;
            }
            else{
                frontrunner = runner;
                if (fronthead == null)
                {
                    fronthead = frontrunner;
                }

                if (fronttail != null)
                {
                    fronttail.next = frontrunner;
                }
                fronttail = frontrunner;
            }
            runner = runner.next;
        }
        if (fronttail != null)
        {
            fronttail.next = rearhead;
        }

        if (reartail != null)
        {
            reartail.next = null;
        }

        return fronthead == null ? rearhead : fronthead;
    }
}
