#pragma once
#include <algorithm>
#include <iostream>

class SortingAlgos {
private:
	static void bubbleSort(int arr[], int n);
	static void selectionSort(int arr[], int n);
	static void insertionSort(int arr[], int n);
	static void mergeSort(int arr[], int l, int r);
	static void quickSort(int arr[], int l, int r);
	static void heapSort(int arr[], int n);
	static void radixSort(int arr[], int n);

public:
	SortingAlgos(); //empty constructor, but will be used to call the sorting functions
	static void merge(int arr[], int l, int m, int r);
	static void partition(int arr[], int low, int high);
	static void heapify(int arr[], int n, int i);
	static void countSort(int arr[], int, int exp);
};