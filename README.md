## Simple Caesar Cipher

* * *
Made By LilithsDemon (Lucy Gardener)
* * *

This repository contains 2 versions of the same CLI application.

- 1 built in python
- 1 built in C#

* * *

While they both created using a CLI this is purely for the quick try of the user.

They are able to be used in other applications by importing them into other projects.

This will allow simple use. 

* * *

## Procedures

* * *

split(word) - This is a simple function that will split text into a list/array of single characters. word is a string variable that you would like to split into a list/array

join(wordList) - Joins an arrray/list into a whole string. wordList is supposed to be an array of single characters however each value can be of different lengths if you wanted.

simple_shift(shiftText, shiftNum) - Very basic shift. Takes the text and will shift it by the value given using a Caesar Cipher. shiftText is a string of the text you want to shift. shiftNum is an integer value representing what you want the shift to be.

advanced_shift(shiftText, shiftNum) - Acts the same as a simple shift however takes out any charcters that are not spaces or alpha characters (a-z or A-Z). This will also add spaces every 5 characters. This is to make encryption more secure. shiftText is a string of the text you want to shift. shiftNum is an integer value representing what you want the shift to be.

simple\_decryption(textToDecrypt, shiftNum) - Works very similarly to simple\_shift(). It will take the text and shift it by a certain amount that is given by the user and return sthe value. textToDecrypt is the string of the text you want to decrypt. shiftNum is the integer value of what you want to shift the text by.

advanced_decryption(textToDecrypt) - This uses the given string textToDecrypt and compares each word in the text file of the most common 1000 words to find any in this text. It will automatically return the decrypted text of what it thinks it is based upon how many words it could find from the most common 1000 words.

start_cli() - This is to just to give a platform that will work. This does not need to be used as you could easily use the other methods without a need for a CLI. This just gives an interface to give it a try.
