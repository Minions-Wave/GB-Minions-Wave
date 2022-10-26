package ru.gb.jseminar;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.awt.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

class HomeworkTest {

    @Test
    void removeNegativeValueSuccessful() {
        List<Integer> expectedList = new ArrayList<>(Arrays.asList(-4,-3,-2,-1,0,1,2,3,4));
        List<Integer> expected = new ArrayList<>(Arrays.asList(0,1,2,3,4));

        Homework hw = new Homework();
        List<Integer> actual = hw.removeNegativeValue(expectedList);

        Assertions.assertEquals(expected, actual);
    }

    @Test
    void getMinSuccessful() {

        List<Integer> expectedList = new ArrayList<>(Arrays.asList(-4,-3,-2,-1,0,1,2,3,4));
        int expected = -4;

        Homework hw = new Homework();
        int actual = hw.getMin(expectedList);

        Assertions.assertEquals(expected, actual);
    }

    @Test
    void getMaxSuccessful() {

        List<Integer> expectedList = new ArrayList<>(Arrays.asList(-4,-3,-2,-1,0,1,2,3,4));
        int expected = 4;

        Homework hw = new Homework();
        int actual = hw.getMax(expectedList);

        Assertions.assertEquals(expected, actual);
    }

    @Test
    void getAverageSuccessful() {
        List<Integer> expectedList = new ArrayList<>(Arrays.asList(1,2,3,4));
        int expected = 2;

        Homework hw = new Homework();
        int actual = hw.getAverage(expectedList);

        Assertions.assertEquals(expected, actual);
    }
}