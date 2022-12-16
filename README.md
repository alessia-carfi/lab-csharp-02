# CONSEGNA LAB-CSHARP-02

### LAB 1-Collections

### LAB 2-Exceptions

### LAB 3-OperatorsOverloading

### CASA 4-ExtensionMethods

Nella classe **Complex**:

- ho creato i le proprietà **Real** e **Imaginary** con i get e i set standard `{ get; set; }`
- nella proprietà **Modulus** ho usato il metodo `Pow()` oltre al `Sqrt()`.

Nella classe **ComplexExtensions**:

- Ho creato un solo metodo **Multiply**
- Nel reciproco non ho usato il modulo per calcolarlo.

### CASA 5-DelegatesAndEvent

- non ho usato il **this** per riferirmi alla mia lista privata e ho nominato la lista con "\_" prima del nome
- Nel metodo `Clear()` ho solo fatto un _for_ che per ogni elemento della lista chiamava una `Remove()`
- Nel metodo `Remove()` chiamavo l'evento **ElementRemoved** e poi usavo il `Remove()` delle liste per rimuovere l'elemento dalla lista
- Nel **RemoveAt** invece richiamo il **Remove** scritto in precedenza
