# MiPresentacion

Aplicación de escritorio hecha con C# y Avalonia UI 11 para registrar datos personales y mostrar un saludo personalizado.

## Ejecutar

Con .NET SDK 10.0 o posterior, ejecuta desde esta carpeta:

```powershell
dotnet run
```

El proyecto utiliza Avalonia UI 11.3.22 y restaura sus paquetes NuGet automáticamente.

## Controles y eventos

La ventana contiene un `StackPanel` con `Margin` y `Spacing`, dentro de un `ScrollViewer` para evitar que los controles queden inaccesibles si se reduce la ventana. Los campos `TxtNombre`, `TxtApellido` y `TxtEdad` capturan los datos; `TxtResultado` muestra los mensajes.

Los botones **Presentarme**, **Limpiar** y **Cambiar saludo** conectan su evento `Click` en `MainWindow.axaml` con métodos de `MainWindow.axaml.cs`. Presentarme valida que nombre y apellido no estén vacíos, y que la edad sea un entero positivo mediante `int.TryParse()`. Limpiar borra los campos, recupera el mensaje inicial, vuelve al saludo estándar y enfoca el campo del nombre. Cambiar saludo alterna entre dos presentaciones; pulsa Presentarme después para ver la seleccionada.

## Reflexión

`MainWindow.axaml` describe los elementos visuales y su organización. `MainWindow.axaml.cs` define qué hacer cuando el usuario actúa. Los nombres `x:Name` dejan que el código acceda a los controles y los eventos `Click` vinculan los botones con los métodos que validan, limpian o actualizan la interfaz.

## Capturas

- [Formulario inicial](capturas/01-formulario.png)
- [Presentación válida](capturas/02-presentacion.png)
- [Mensaje de validación](capturas/03-validacion.png)
