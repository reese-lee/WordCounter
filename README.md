# _Word Counter_

#### _A console app that checks how frequently a word appears in a sentence, April 26, 2019_

#### By _**Reese Lee**_

## Description

_This is a console app that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It will check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral", the first three letters of the word cathedral would not be counted.) _

## Setup/Installation Requirements

1. Open [repo](https://github.com/reese-lee/WordCounter.git)
2. Clone repo
3. Compile and execute program
4. Use program in console

## Known Bugs

_No known issues at this time._

## Specs
| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| It will take a word from a user. | Cat (This is a simple word.) | Cat |
| It will take a sentence from a user. | This cat is big. (This is a simple sentence.) | This cat is big. | 
| It will take a word and a sentence from a user. | Cat, This cat is big. (This is a simple word and sentence, and it appears once in the sentence.) | Cat, This cat is big |
| It will check for full word matches of the word in the sentence. | Cat, This cat is big in the cathedral. (This is a simple word and sentence; the sentence contains both the word 'cat' and an example of a word that contains the word 'cat'  but is not a full word match.) | 1 |
| It will check how frequently the word appears in the provided sentence. | Cat, This cat is big. (This is a simple word and a simple sentence, and the program will be checking the number of times that word appears in the sentence.) | 1 |
| It will check for special cases such as plural versions of the word. | Cat, This cat is big in the cathedral but those cats over there are some small cats. | 3 |


## Support and contact details

_Please email reese.lee.cy@gmail.com with any questions._

## Technologies Used

_C#._

### License

*MIT License*

Copyright (c) 2019 **_Reese Lee _**
