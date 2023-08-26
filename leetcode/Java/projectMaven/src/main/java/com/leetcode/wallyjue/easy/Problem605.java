package com.leetcode.wallyjue.easy;

public class Problem605 {
    public boolean canPlaceFlowers(int[] flowerbed, int n) {
        if (n == 0) return true;

        if (flowerbed.length == 1)
            return flowerbed[0] == 0;

        for(int cnt = 0;cnt < flowerbed.length;cnt++) {
            if (cnt == 0) {
                if (flowerbed[0] == 0 && flowerbed[1] == 0) {
                    n--;
                    flowerbed[0] = 1;
                    cnt++;
                }
            } else if (cnt == flowerbed.length - 1) {
                if (flowerbed[flowerbed.length - 1] == 0 && flowerbed[flowerbed.length - 2] == 0){
                    n--;
                    flowerbed[flowerbed.length - 1] = 1;
                }
            } else {
                if (flowerbed[cnt - 1] == 0 && flowerbed[cnt] == 0 && flowerbed[cnt + 1] == 0) {
                    n--;
                    flowerbed[cnt] = 1;
                    cnt++;
                }
            }
            if (n == 0) return true;
        }

        return false;
    }
}
