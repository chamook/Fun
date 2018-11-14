using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Fun.Unit;

#pragma warning disable 1591

// ReSharper disable InconsistentNaming

namespace Fun
{
    public static class Fun
    {
        // enables type inference on lambdas
        public static Func<TR> Func<TR>(Func<TR> f) => f;
        public static Func<T1, TR> Func<T1, TR>(Func<T1, TR> f) => f;
        public static Func<T1, T2, TR> Func<T1, T2, TR>(Func<T1, T2, TR> f) => f;
        public static Func<T1, T2, T3, TR> Func<T1, T2, T3, TR>(Func<T1, T2, T3, TR> f) => f;
        public static Func<T1, T2, T3, T4, TR> Func<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> f) => f;
        public static Func<T1, T2, T3, T4, T5, TR> Func<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> f) => f;
        public static Func<T1, T2, T3, T4, T5, T6, TR> Func<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> f) => f;
        public static Func<T1, T2, T3, T4, T5, T6, T7, TR> Func<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> f) => f;

        public static Func<Unit> Func(Action f) =>
            () => { f(); return unit; };
        public static Func<T1, Unit> Func<T1>(Action<T1> f) =>
            a1 => { f(a1); return unit; };
        public static Func<T1, T2, Unit> Func<T1, T2>(Action<T1, T2> f) =>
            (a1, a2) => { f(a1, a2); return unit; };
        public static Func<T1, T2, T3, Unit> Func<T1, T2, T3>(Action<T1, T2, T3> f) =>
            (a1, a2, a3) => { f(a1, a2, a3); return unit; };
        public static Func<T1, T2, T3, T4, Unit> Func<T1, T2, T3, T4>(Action<T1, T2, T3, T4> f) =>
            (a1, a2, a3, a4) => { f(a1, a2, a3, a4); return unit; };
        public static Func<T1, T2, T3, T4, T5, Unit> Func<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> f) =>
            (a1, a2, a3, a4, a5) => { f(a1, a2, a3, a4, a5); return unit; };
        public static Func<T1, T2, T3, T4, T5, T6, Unit> Func<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> f) =>
            (a1, a2, a3, a4, a5, a6) => { f(a1, a2, a3, a4, a5, a6); return unit; };
        public static Func<T1, T2, T3, T4, T5, T6, T7, Unit> Func<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> f) =>
            (a1, a2, a3, a4, a5, a6, a7) => { f(a1, a2, a3, a4, a5, a6, a7); return unit; };


        public static Action Act(Action f) => f;
        public static Action<T1> Act<T1>(Action<T1> f) => f;
        public static Action<T1, T2> Act<T1, T2>(Action<T1, T2> f) => f;
        public static Action<T1, T2, T3> Act<T1, T2, T3>(Action<T1, T2, T3> f) => f;
        public static Action<T1, T2, T3, T4> Act<T1, T2, T3, T4>(Action<T1, T2, T3, T4> f) => f;
        public static Action<T1, T2, T3, T4, T5> Act<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> f) => f;
        public static Action<T1, T2, T3, T4, T5, T6> Act<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> f) => f;
        public static Action<T1, T2, T3, T4, T5, T6, T7> Act<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> f) => f;

        public static Func<T1, Func<T2, TR>> Curry<T1, T2, TR>(this Func<T1, T2, TR> f) =>
            a => b => f(a, b);
        public static Func<T1, Func<T2, Func<T3, TR>>> Curry<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> f) =>
            a => b => c => f(a, b, c);
        public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> Curry<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> f) =>
            a => b => c => d => f(a, b, c, d);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> Curry<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> f) =>
            a => b => c => d => e => f(a, b, c, d, e);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> Curry<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, T2, T3, T4, T5, T6, TR> func) =>
            a => b => c => d => e => f => func(a, b, c, d, e, f);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, TR> func) =>
            a => b => c => d => e => f => g => func(a, b, c, d, e, f, g);

        public static Func<T1, T2, TR> Uncurry<T1, T2, TR>(this Func<T1, Func<T2, TR>> f) =>
            (a, b) => f(a)(b);
        public static Func<T1, T2, T3, TR> Uncurry<T1, T2, T3, TR>(this Func<T1, Func<T2, Func<T3, TR>>> f) =>
            (a, b, c) => f(a)(b)(c);
        public static Func<T1, T2, T3, T4, TR> Uncurry<T1, T2, T3, T4, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> f) =>
            (a, b, c, d) => f(a)(b)(c)(d);
        public static Func<T1, T2, T3, T4, T5, TR> Uncurry<T1, T2, T3, T4, T5, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> f) =>
            (a, b, c, d, e) => f(a)(b)(c)(d)(e);
        public static Func<T1, T2, T3, T4, T5, T6, TR> Uncurry<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> func) =>
            (a, b, c, d, e, f) => func(a)(b)(c)(d)(e)(f);
        public static Func<T1, T2, T3, T4, T5, T6, T7, TR> Uncurry<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> func) =>
            (a, b, c, d, e, f, g) => func(a)(b)(c)(d)(e)(f)(g);

        public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T2, T3> b, Func<T1, T2> a) =>
            v => b(a(v));
        public static Func<T1, T3> ComposeBack<T1, T2, T3>(this Func<T1, T2> a, Func<T2, T3> b) =>
            v => b(a(v));

        public static Func<T2, Func<T1, TR>> Flip<T1, T2, TR>(this Func<T1, Func<T2, TR>> f) =>
            a => b => f(b)(a);

        // partial application
        public static Func<T2, TR> Apply<T1, T2, TR>(this Func<T1, T2, TR> func, T1 a) =>
            b => func(a, b);
        public static Func<T3, TR> Apply<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func, T1 a, T2 b) =>
            c => func(a, b, c);
        public static Func<T2, T3, TR> Apply<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func, T1 a) =>
            (b, c) => func(a, b, c);
        public static Func<T4, TR> Apply<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> func, T1 a, T2 b, T3 c) =>
            d => func(a, b, c, d);
        public static Func<T3, T4, TR> Apply<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> func, T1 a, T2 b) =>
            (c, d) => func(a, b, c, d);
        public static Func<T2, T3, T4, TR> Apply<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> func, T1 a) =>
            (b, c, d) => func(a, b, c, d);
        public static Func<T5, TR> Apply<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> func, T1 a, T2 b, T3 c, T4 d) =>
            e => func(a, b, c, d, e);
        public static Func<T4, T5, TR> Apply<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> func, T1 a, T2 b, T3 c) =>
            (d, e) => func(a, b, c, d, e);
        public static Func<T3, T4, T5, R> Apply<T1, T2, T3, T4, T5, R>(this Func<T1, T2, T3, T4, T5, R> func, T1 a, T2 b) =>
            (c, d, e) => func(a, b, c, d, e);
        public static Func<T2, T3, T4, T5, R> Apply<T1, T2, T3, T4, T5, R>(this Func<T1, T2, T3, T4, T5, R> func, T1 a) =>
            (b, c, d, e) => func(a, b, c, d, e);


        public static Func<T1, TR> ApplyLeft<T1, T2, TR>(this Func<T1, T2, TR> func, T2 b) =>
            a => func(a, b);

        public static Action<T2> Apply<T1, T2>(this Action<T1, T2> func, T1 a) =>
            b => func(a, b);
        public static Action<T3> Apply<T1, T2, T3>(this Action<T1, T2, T3> func, T1 a, T2 b) =>
            c => func(a, b, c);
        public static Action<T2, T3> Apply<T1, T2, T3>(this Action<T1, T2, T3> func, T1 a) =>
            (b, c) => func(a, b, c);
        public static Action<T4> Apply<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> func, T1 a, T2 b, T3 c) =>
            d => func(a, b, c, d);
        public static Action<T3, T4> Apply<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> func, T1 a, T2 b) =>
            (c, d) => func(a, b, c, d);
        public static Action<T2, T3, T4> Apply<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> func, T1 a) =>
            (b, c, d) => func(a, b, c, d);
        public static Action<T5> Apply<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> func, T1 a, T2 b, T3 c, T4 d) =>
            e => func(a, b, c, d, e);
        public static Action<T4, T5> Apply<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> func, T1 a, T2 b, T3 c) =>
            (d, e) => func(a, b, c, d, e);
        public static Action<T3, T4, T5> Apply<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> func, T1 a, T2 b) =>
            (c, d, e) => func(a, b, c, d, e);
        public static Action<T2, T3, T4, T5> Apply<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> func, T1 a) =>
            (b, c, d, e) => func(a, b, c, d, e);

        // Pipe support
        public static TResult Pipe<TValue, TResult>(this TValue @this, Func<TValue, TResult> func) =>
            func(@this);
        public static async Task<TResult> Pipe<TValue, TResult>(this Task<TValue> @this, Func<TValue, TResult> func) =>
            func(await @this);

        public static async Task<TResult> PipeAsync<TValue, TResult>(this TValue @this, Func<TValue, Task<TResult>> func) =>
            await func(@this);
        public static async Task<TResult> PipeAsync<TValue, TResult>(this Task<TValue> @this, Func<TValue, Task<TResult>> func) =>
            await func(await @this);

        // Chainable if
        public static TResult If<TValue, TResult>(this TValue @this, Func<TValue, bool> If, Func<TValue, TResult> Then, Func<TValue, TResult> Else) =>
            If(@this)
            ? Then(@this)
            : Else(@this);
        public static async Task<TResult> If<TValue, TResult>(this Task<TValue> @this, Func<TValue, bool> If, Func<TValue, TResult> Then, Func<TValue, TResult> Else)
        {
            var value = await @this;
            return If(value)
                ? Then(value)
                : Else(value);
        }

        public static async Task<TResult> IfAsync<TValue, TResult>(this TValue @this, Func<TValue, Task<bool>> If, Func<TValue, Task<TResult>> Then, Func<TValue, Task<TResult>> Else) =>
            (await If(@this))
                ? await Then(@this)
                : await Else(@this);
        public static async Task<TResult> IfAsync<TValue, TResult>(this TValue @this, Func<TValue, bool> If, Func<TValue, Task<TResult>> Then, Func<TValue, Task<TResult>> Else) =>
            If(@this)
                ? await Then(@this)
                : await Else(@this);
        public static async Task<TResult> IfAsync<TValue, TResult>(this TValue @this, Func<TValue, Task<bool>> If, Func<TValue, TResult> Then, Func<TValue, TResult> Else) =>
            (await If(@this))
                ? Then(@this)
                : Else(@this);
        public static async Task<TResult> IfAsync<TValue, TResult>(this Task<TValue> @this, Func<TValue, Task<bool>> If, Func<TValue, Task<TResult>> Then, Func<TValue, Task<TResult>> Else)
        {
            var value = await @this;
            return (await If(value))
                ? await Then(value)
                : await Else(value);
        }
        public static async Task<TResult> IfAsync<TValue, TResult>(this Task<TValue> @this, Func<TValue, bool> If, Func<TValue, Task<TResult>> Then, Func<TValue, Task<TResult>> Else)
        {
            var value = await @this;
            return If(value)
                ? await Then(value)
                : await Else(value);
        }
        public static async Task<TResult> IfAsync<TValue, TResult>(this Task<TValue> @this, Func<TValue, Task<bool>> If, Func<TValue, TResult> Then, Func<TValue, TResult> Else)
        {
            var value = await @this;
            return (await If(value))
                ? Then(value)
                : Else(value);
        }

        // Execute an action for side effect without breaking the pipe
        public static TValue Tee<TValue>(this TValue @this, Action<TValue> act)
        {
            act(@this);
            return @this;
        }
        public static TValue Tee<TValue>(this TValue @this, Action act)
        {
            act();
            return @this;
        }
        public static async Task<TValue> Tee<TValue>(this Task<TValue> @this, Action<TValue> act)
        {
            var value = await @this;
            act(value);
            return value;
        }
        public static async Task<TValue> Tee<TValue>(this Task<TValue> @this, Action act)
        {
            act();
            return await @this;
        }

        public static async Task<TValue> TeeAsync<TValue>(this TValue @this, Func<TValue, Task> act)
        {
            await act(@this);
            return @this;
        }
        public static async Task<TValue> TeeAsync<TValue>(this TValue @this, Func<Task> act)
        {
            await act();
            return @this;
        }
        public static async Task<TValue> TeeAsync<TValue>(this Task<TValue> @this, Func<TValue, Task> act)
        {
            var value = await @this;
            await act(value);
            return value;
        }
        public static async Task<TValue> TeeAsync<TValue>(this Task<TValue> @this, Func<Task> act)
        {
            var val = await @this;
            await act();
            return val;
        }

        // For the bad OO cases when a function is executed for side effect, but also returns a value that we want to ignore
        public static TValue TeeIgnore<TValue, TResult>(this TValue @this, Func<TValue, TResult> func)
        {
            func(@this);
            return @this;
        }
        public static async Task<TValue> TeeIgnore<TValue, TResult>(this Task<TValue> @this, Func<TValue, TResult> func)
        {
            var value = await @this;
            func(value);
            return value;
        }

        // Special functions
        public static T Identity<T>(T x) => x;

        // The return type of this function is "used". This allows exceptions to be thrown in ternary operators, LINQ expressions etc.
        public static TR Raise<TR>(Exception ex)
        {
            throw ex;
        }

        public static System.Collections.Generic.List<T> EmptyList<T>() => new List<T>();
    }
}
