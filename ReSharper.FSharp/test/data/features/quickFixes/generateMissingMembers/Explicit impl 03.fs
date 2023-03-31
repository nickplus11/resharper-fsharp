type I =
    abstract P1: int
    abstract P2: int
    abstract M1: int -> unit
    abstract M2: int -> unit

[<AbstractClass>]
type A() =
    abstract P1: int

    abstract P2: int
    default this.P2 = 1

    abstract M1: int -> unit

    abstract M2: int -> unit
    default this.M2(i) = ()

    interface I with
        member this.P1 = this.P1
        member this.P2 = this.P2
        member this.M1(i) = this.M1(i)
        member this.M2(i) = this.M2(i)

type B{caret}() =
    inherit A()
