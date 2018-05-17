#pragma once
#include "DATA.h"
#include <iostream>
class HashTable
{
public:
	HashTable(int n);
	~HashTable();
	bool insert(DATA *data);
	void remove(int key);
	DATA find(int key);
	void print();
private:
	DATA *hashArray;
	int size = NULL;

};

