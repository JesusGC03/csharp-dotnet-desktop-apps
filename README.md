# C# .NET Windows Forms Desktop Applications & Concurrency

<div align="center">

![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/Platform-.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![GUI](https://img.shields.io/badge/UI-Windows_Forms-0078D7?style=for-the-badge&logo=windows&logoColor=white)
![IDE](https://img.shields.io/badge/IDE-Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

</div>

Desktop software suite developed with **C#** and **.NET Windows Forms**, covering event-driven architecture, custom 2D graphics rendering with **GDI+**, asynchronous multithreading, and input validation.

Developed as part of the **Visual Programming (Programación Visual)** curriculum at **Escuela Politécnica Superior (Universidad de Alcalá)**.

---

## 🎯 Key Software Engineering Competencies

* **Event-Driven Architecture:** UI lifecycle management, custom event publishers/subscribers, and form communication across modal/modeless dialogs.
* **Custom GDI+ 2D Vector Graphics:** Math-driven rendering (`Graphics`, `Pen`, `Brush`, trigonometric projection) for responsive analog clock faces and real-time hand animation.
* **N-Tier Database Architecture & ADO.NET:** Decoupled 3-tier enterprise pattern (DAL, BLL, UI) executing SQL Server stored procedures and custom data-bound UserControls.
* **Thread-Safe UI Synchronization:** Concurrency handling with `Thread` and `BackgroundWorker`, avoiding cross-thread race conditions via `Control.Invoke` and `BeginInvoke`.
* **State Management & Persistence:** Dynamic timezone data structures, list serialization, and multi-form state propagation.
* **Input Validation & Security:** Form-level validation using regular expressions, masked password inputs, and `ErrorProvider` feedback.

---

## 📁 Repository Structure

```text
csharp-dotnet-desktop-apps/
├── 01-laboratorios-principales/
│   ├── P1_Reloj/                # Core digital clock application with periodic timer events
│   ├── P2_Reloj/                # Multi-window interface with modal dialogs and data passing
│   ├── P3_Reloj/                # Analog clock UserControl with custom GDI+ drawing (OnPaint)
│   ├── P4_Reloj/                # World clock with dynamic timezone calculation and persistence
│   ├── P5_VisorImagenes/        # Image processing viewer with zooming, filtering, and scaling
│   ├── P6_Hilos/                # Multithreaded processing engine with thread-safe UI updates
│   └── P7_BaseDatos_N-Capas/    # N-Tier architecture (DAL, BLL, BO, UI) with ADO.NET & SQL Server
└── 02-ejercicios-tematicos/
    ├── Ejercicio2-Tema1-PEI1/   # Secure authentication dialog with password masking
    ├── Ejercicio3_Tema1_Parte1/ # Parent-child form ownership and lifecycle delegation
    ├── Ejercicio6_Tema2/        # Dynamic control generation and runtime event routing
    ├── Ejercicio7-Tema3/        # Form validation using Regex and ErrorProvider controls
    ├── Ejercicio10_Tema5_Imagenes/ # Image manipulation with GDI+ and PictureBox controls
    └── Ejercicio11_Tema6_Hilos/    # Concurrent background workers with progress reporting
```

---

## 🔬 Core Projects Breakdown

### 1. World Clock Suite (`P1_Reloj` to `P4_Reloj`)
* **Vector Dial Rendering:** Implements Cartesian-to-polar coordinate transformations to dynamically draw hour, minute, and second needles with sub-second accuracy.
* **Timezone Architecture:** Manages timezone offsets, daylight saving time adjustments, and structured list bindings.
* **Modular Dialogs:** Includes configuration modals (`DlgDatosZona`, `DlgEliminarZona`, `EditHora`, `AcercaDe`).

### 2. Digital Image Viewer (`P5_VisorImagenes`)
* High-performance bitmap rendering and image transformation.
* Custom aspect-ratio preservation and dynamic image zooming.

### 3. Asynchronous Concurrency Engine (`P6_Hilos` & `Ejercicio11`)
* Offloads computationally intensive loops to background worker threads to maintain responsive 60 FPS UI rendering.
* Safely marshals background thread outputs to UI elements using `MethodInvoker` delegates.

### 4. Input & Form Validation (`Ejercicio2` & `Ejercicio7`)
* Enforces strict regex validation patterns on text fields before persistence.
* Visual error notification with contextual tooltips and real-time error clearance.

### 5. N-Tier Enterprise Database Application (`P7_BaseDatos_N-Capas`)
* **Decoupled Architecture:** Strict separation of concerns between Data Access Layer (`CFamosoDAL`), Business Logic Layer (`CFamosoBLL`), and Business Objects (`CFamosoBO`, `ColCFamosos`).
* **ADO.NET Integration:** Executes SQL Server Stored Procedures (`stproObtenerFilasFamosos`) using `SqlConnection`, `SqlCommand`, and `SqlDataReader` with safe resource disposal (`using` blocks).
* **Custom Data-Bound UserControl:** Custom UI control (`ElementoLista`) binding database entities directly to UI components with custom image format conversion handlers (`StringToBitmap`).

---

## 🛠️ Toolchain & Execution

1. **IDE:** Microsoft Visual Studio (Community / Professional).
2. **Framework:** .NET Framework 4.7.2 / 4.8.
3. **Execution:** Open any `.sln` solution file in Visual Studio, select `Debug` or `Release`, and press `F5`.

---

## 👤 Author

**Jesús Gay Canelada**  
Telematics Engineering Student @ Universidad de Alcalá (UAH)  
- LinkedIn: [linkedin.com/in/jesus-gay](https://www.linkedin.com/in/jesus-gay)  
- GitHub: [@JesusGC03](https://github.com/JesusGC03)  
- Email: [jgaycanelada@gmail.com](mailto:jgaycanelada@gmail.com)

