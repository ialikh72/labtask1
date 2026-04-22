# 🗣️ Speech Introduction App (C# Windows Forms)

## 📌 Overview

This is a simple **C# Windows Forms application** that introduces a person using both **text** and **voice output**.
When the user clicks on different images (PictureBoxes), the program displays and speaks the person's introduction.

---

## 🚀 Features

* 👤 Stores personal information (name, age, gender, address)
* 🖼️ Uses **PictureBox clicks** to trigger actions
* 💬 Displays introduction using `MessageBox`
* 🔊 Converts text to speech using `SpeechSynthesizer`

---

## 🛠️ Technologies Used

* C# (.NET Framework)
* Windows Forms (WinForms)
* `System.Speech.Synthesis` for voice output

---

## 📂 Project Structure

* **Form1.cs**

  * Contains UI logic and event handling
* **pic class**

  * Custom class to store person data
  * Method `introduce()` returns formatted introduction

---

## ▶️ How It Works

1. Application starts with a default person (**John Doe**).
2. When **PictureBox1** is clicked:

   * Displays introduction of John Doe
   * Speaks the introduction
3. When **PictureBox2** is clicked:

   * Changes data to **Jane Smith**
   * Displays and speaks new introduction

---

## 💡 Example Output

"My name is John Doe. I am 30 years old. I am a Male. I live at 123 Main St, Anytown, USA."

---

## ⚙️ Requirements

* Visual Studio
* .NET Framework
* Add reference to:

  * `System.Speech`

---

## 📌 Notes

* Make sure your system audio is enabled 🔊
* If speech doesn't work:

  * Check if `System.Speech` reference is added
  * Ensure speakers/headphones are connected

---

## 👨‍💻 Author

**Muhammad Ali**
Software Engineering Student
