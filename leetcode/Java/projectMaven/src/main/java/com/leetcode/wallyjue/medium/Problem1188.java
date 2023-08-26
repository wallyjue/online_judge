package com.leetcode.wallyjue.medium;

import java.util.LinkedList;
import java.util.concurrent.locks.Condition;
import java.util.concurrent.locks.ReentrantLock;

public class Problem1188 {
    private LinkedList<Integer> queue;
    private Condition full;
    private Condition empty;
    private ReentrantLock access;
    private int capacity;
    public Problem1188(int capacity) {
        this.capacity = capacity;
        queue = new LinkedList();
        access = new ReentrantLock();
        full = access.newCondition();
        empty = access.newCondition();
    }

    public void enqueue(int element) throws InterruptedException {
        access.lock();
        try {
            while (queue.size() == this.capacity)
            {
                full.await();
            }
            queue.add(element);
            empty.signal();
        } finally {
            access.unlock();
        }
    }

    public int dequeue() throws InterruptedException {
        access.lock();
        int ret = 0;
        try {
            while (queue.size() == 0)
            {
                empty.await();
            }
            ret = queue.remove();
            full.signal();
        } finally {
            access.unlock();

        }
        return ret;
    }

    public int size() {
        return queue.size();
    }
}
