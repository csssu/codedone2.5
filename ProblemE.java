/**
 * @file ProblemFifth.java
 * @author amir aghazadeh (cssu.ama@gmail.com)
 * @brief scheduling activites
 * @version 0.1.0
 * @date 2022-09-02
 *
 * @copyright Copyright (c) 2022
 *
 */

import java.util.Scanner;

public class ProblemFifth {
    public static void swap(int[] array, int firstIndex, int secondIndex) {
        int temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
    }

    public static void sort(int[] endTimes, int[] startTimes) {
        for (int i = 0; i < endTimes.length; i++) {
            for (int j = 0; j < endTimes.length - i - 1; j++) {
                if (endTimes[j] > endTimes[j + 1]) {
                    swap(endTimes, j, j + 1);
                    swap(startTimes, j, j + 1);
                }
            }
        }
    }

    public static void main(String[] args) {
        var scanner = new Scanner(System.in);
        int N = scanner.nextInt();

        int[] startTimes = new int[N];
        for (int i = 0; i < N; i++) {
            startTimes[i] = scanner.nextInt();
        }

        int[] endTimes = new int[N];
        for (int i = 0; i < N; i++) {
            endTimes[i] = scanner.nextInt();
        }

        sort(endTimes, startTimes);

        int sum = 1;
        int j = 0;

        for (int i = 1; i < N; i++) {
            if (endTimes[j] <= startTimes[i]) {
                j = i;
                sum++;
            }
        }

        System.out.println(sum);

        scanner.close();
    }
}