# MasterAnimalShelter Api
### By **Keturah Howard**  April 3rd 2020

ASP.NET core API application to create database of animals for an animal shelter. This API Application is about an animal shelter where but with a twist- These animals are more powerful than you and when you adopt you are submitting to serve them through life! Wha-oh! Very fun. Store information such as PowerStatus intergers and ironically assign adorable and benign animal photo links to your added masters. You can interact with this API by installing and running it, and then installing running and opening [this interface application](https://github.com/KeturahDev/AnimalShelterInterface.Solution) made specifically for this Api.

## Specifications 

### user stories:

* As a user, I want to be able to GET all Animals.
* As a user, I want to be able to GET details of Animals (type, personality, gender, age, social status).
* As a user, I want to be able to POST Animals.
* As a user, I want to be able to PUT Animals.
* As a user, I want to be able to Delete Animals.
* As a user, I want to input type parameters and retrieve only Animals under that type.
* As a user, I want to input personality parameters and retrieve only Animals under that personality.
* As a user, I want to input gender parameters and retrieve only Animals under that gender.
* As a user, I want to input age parameters and retrieve only Animals under that age.
* As a user, I want to input social status parameters and retrieve only Animals under that social status.

### API Endpoints

ANIMALS
```
GET /api/animals
POST /api/animals
GET /api/animals/{animalId}
PUT /api/animal/{animalId}
DELETE /api/animal/{animalId}
```

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/KeturahDev/MasterAnimalShelter.git
    ```

2. Restore all dependencies:
    ```
    dotnet restore
    ```

### Open program

3. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```

## Technologies Used

* C#
* ASP.NET core MVC 2.2
* RestSharp API
* Newtonsoft.Json
* Git

## External Assets
* MySqlWorkBench
* Postman


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at keturah.dev@gmail.com.

## License

Licensed under the MIT license.

&copy; 2020 Keturah Howard.
