# 📌 Crud in c#

A C# Crud using wndows form and MySql. 

## 🚀 Technologies

This project was developed using the following technologies:

- [Visual Studio](https://visualstudio.microsoft.com/pt-br/)
- [MySql](https://www.mysql.com/)

## 📂 Project Structure

```
/project-root
│── 📁 atvcrud            # Main folder
│── 📝 .gitattributes           # Atributes from gt
│── 📝 .gitignore         # Ignore this
│── 📄 README.md      # This file
│── 📄 atvcrud.sln     # Visual Studio extension
```

## 📥 Installation

1. **Clone the repository**
   ```sh
   git clone https://github.com/yourusername/projectname.git
   cd projectname
   ```

2. **Open the project in Visual Studio**
   - Launch **Visual Studio**.
   - Click on **Open a project or solution**.
   - Navigate to the cloned repository folder and open the `.sln` file.

3. **Restore NuGet Packages**
   - In **Solution Explorer**, right-click on the solution and select **Restore NuGet Packages**.

3. **Start the MySql Server**
   
5. - Start the MySql server and enter the following commands:
     ```sh
     CREATE DATABASE bdescola;
     USE bdescola;
     CREATE TABLE tabela (
      id INT AUTO_INCREMENT PRIMARY KEY,
      nome VARCHAR(100) NOT NULL,
      idade INT NOT NULL,
      unidade CHAR(1) NOT NULL,
      serie INT NOT NULL,
      turma VARCHAR(10) NOT NULL
     );
     ```
     
6. - In the file **ConexaoAluno.cs** change:
     ```sh
     "comn = new MySqlConnection("Persist Security info=false; server=localhost; database=bdescola; user=root; pwd=****;");"
     ```
     To your server settings!

7. **Build and Run the Project**
   - Click on **Build > Build Solution** (or press `Ctrl+Shift+B`).
   - Click **Start** (`F5`) to run the application.

Now, the project should be up and running! 🚀


## 🤝 Contributing

Feel free to contribute! Just follow these steps:

1. Fork the project.
2. Create a **branch** with your feature (`git checkout -b my-feature`).
3. Commit your changes (`git commit -m 'Adding my feature'`).
4. Push to the branch (`git push origin my-feature`).
5. Open a **Pull Request**.

## 📬 Contact

- **Ryan** - [ryanferreira4883@gmail.com](mailto:ryanferreira4883@gmail.com)
- **GitHub** - [https://github.com/ferreiraryan](https://github.com/ferreiraryan)
- **LinkedIn** - [https://www.linkedin.com/in/ferryan/](https://www.linkedin.com/in/ferryan/)
