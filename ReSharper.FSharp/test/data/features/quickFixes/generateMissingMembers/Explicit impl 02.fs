type I =
    abstract P: int
    abstract M: int -> unit

[<AbstractClass>]
type A() =
    abstract P: int
    abstract M: int -> unit

    interface I with
        member this.P = this.P
        member this.M(i) = this.M(i)

type B{caret}() =
    inherit A()
