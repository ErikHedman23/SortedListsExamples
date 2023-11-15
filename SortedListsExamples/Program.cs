//Examples of SortedList

//Methods for SortedList

/* 
 * Clear() - Removes all the elements from the sorted list.

ContainsKey(K key) - Returns true when the specified key is present in the sorted list.

ContainsValue(V value) - Returns true when a specified value is present in the sorted list.

IndexOfKey(K key) - Returns the index of the specified key within the sorted list.

IndexOfValue(V value) - Returns the index of the specified value within the sorted list.

Add(K key, V value) - Adds an element with a specific key, value pair into the sorted list.

Remove(K key) - Removes the element with the specific key, value pair associated with the specified key from the sorted list.

Propeties:

Count - Gets the number of key/value pairs contained in the sorted list.

Item[K key] - Gets or sets the value associated the specified key contained in the sorted list. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the key, value.

Keys - Gets a sorted and indexed collection containing only the keys in the sorted list.

Values - Gets a sorted and indexed collection of the values in the sorted list.

*/

/* Bit Arrays:
 * A bit array is a collection of bits. The value of a bit can be either 0 (off/false) or 1 (on/true).

Bit arrays compactly store bits. Most commonly, they are used to represent a simple group of boolean flags or an ordered sequence of boolean values. 
 * 
 * 
 * Methods:
 * Get(int i) - Gets the value of the bit at a specified position i in the bit array.

Set(int i, bool value) - Sets the bit at a specified position i to a specified value in the bit array.

SetAll(bool value) - Sets all the bits to a specified value in the bit array.

And(BitArray ba) - Performs the bitwise AND operation on the elements of the bit array object with a specified bit array ba.

Or(BitArray ba) - Performs the bitwise OR operation on the elements of the bit array and the specified bit array ba.

Not() - Inverts the bit values of the bit array.

Xor(BitArray ba) - Performs the bitwise XOR operation on the elements of the current bit array object and the elements in the specified bit array ba.


BitArray properties include:

Count -  Gets the number of bits in the bit array.

IsReadOnly - Gets a value indicating if the bit array is read only or not.

*/

using System.Collections;
using System;
using SortedListsExamples;



BitArray ba1 = new BitArray(4);
BitArray ba2 = new BitArray(4);

ba1.SetAll(true);
ba2.SetAll(false);

ba1.Set(2, false);
ba2.Set(3, true);

BitArrayExample.PrintBarr("ba1", ba1);
BitArrayExample.PrintBarr("ba2", ba2);
Console.WriteLine();

BitArrayExample.PrintBarr("ba1 AND ba2", ba1.And(ba2));
BitArrayExample.PrintBarr("    NOT ba2", ba2.Not());
