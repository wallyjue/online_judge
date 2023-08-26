package com.leetcode.wallyjue.easy;

import java.util.concurrent.atomic.AtomicInteger;

public class Problem1114 {
    private AtomicInteger one = new AtomicInteger(0);
    private AtomicInteger two = new AtomicInteger(0);
    public Problem1114() {

    }

    public void first(Runnable printFirst) throws InterruptedException {

        // printFirst.run() outputs "first". Do not change or remove this line.

        printFirst.run();
        one.incrementAndGet();
    }

    public void second(Runnable printSecond) throws InterruptedException {
        while( this.one.get() != 1 ){

        }

        // printSecond.run() outputs "second". Do not change or remove this line.
        printSecond.run();
        this.two.incrementAndGet();
    }

    public void third(Runnable printThird) throws InterruptedException {
        while( this.two.get() != 1 ){

        }


        // printThird.run() outputs "third". Do not change or remove this line.
        printThird.run();
    }
}
