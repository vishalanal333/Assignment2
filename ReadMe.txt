Assignment 2 : 
- Create a console app 
- read sample.json file 
- Print sorted user details having age >= 18

Working:-
We create class 'Sample' which will hold the keys of sample.json file.
We create class 'Programe' which will have 'Main' function and create fileName variable which contain 'sample.json'. Then we will read the file using File.ReadAllText().
Crate the object 'sample' whose type will be List<Sample> and we serialize and deserialize the data.
Now we call foreach loop on sample and use OrderBy to order the data according to age. Inside loop we check weather age >= 18. If the age >=18 the we print it on console.

