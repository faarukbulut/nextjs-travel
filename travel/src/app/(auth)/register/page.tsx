"use client"
import React, { useState } from 'react'
import { zodResolver } from "@hookform/resolvers/zod"
import { useForm } from "react-hook-form"
import { z } from "zod"
import { Button } from "@/components/ui/button"
import {
  Form,
  FormControl,
  FormDescription,
  FormField,
  FormItem,
  FormLabel,
  FormMessage,
} from "@/components/ui/form"
import { Input } from "@/components/ui/input" 
import { useRouter } from 'next/navigation'
import Link from 'next/link'
import { apiBase } from '@/constants'

const registerSchema = z.object({
  email: z.string().min(1, "Email is required").email("Please enter a valid email"),
  username: z.string().min(1, "Username is required"),
  password: z.string().min(6, "Password must be at least 6 characters long"),
  firstName: z.string().min(1, "First Name is required"),
  lastName: z.string().min(1, "Last Name is required"),
})

type RegisterFormValues = z.infer<typeof registerSchema>;

const RegisterPage = () => {

  const router = useRouter();
  const [error, setError] = useState("");
  const [success, setSuccess] = useState("");

  const form = useForm<RegisterFormValues>({
    resolver: zodResolver(registerSchema),
    defaultValues: {
      email: "",
      username: "",
      password: "",
      firstName: "",
      lastName: "",
    },
  });

  const onSubmit = async (data: RegisterFormValues) => {
    setError("");
    setSuccess("");

    try {
        const response = await fetch(`${apiBase}/api/User/CreateUser`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(data),
        });

        if(!response.ok){
            const text = await response.text();
            const result = text ? JSON.parse(text) : {};
            setError(result.message || "Registration failed")
        }else{
            setSuccess("Success")

            setTimeout(() => {router.push("/login")}, 4000);
        }

    } catch (error) {
        setError("An unexpected error occurred");
    }
    
  }

  return (
    <div className='min-h-screen flex items-center justify-center p-4'>
      <div className='bg-slate-50 shadow-md rounded px-8 pt-6 pb-8 w-full max-w-md'>
        <h1 className='text-2xl font-bold mb-6 text-center'>Register</h1>
        {error && <p className='text-red-500 mb-4'>{error}</p>}
        {success && <p className='text-green-500 mb-4'>{success}</p>}

        <Form {...form}>
          <form onSubmit={form.handleSubmit(onSubmit)} className="space-y-8">
            <FormField
              control={form.control}
              name="email"
              render={({ field }) => (
                <FormItem>
                  <FormLabel>Email</FormLabel>
                  <FormControl>
                    <Input type="email" {...field} />
                  </FormControl>
                  <FormMessage />
                </FormItem>
              )}
            />

            <FormField
              control={form.control}
              name="username"
              render={({ field }) => (
                <FormItem>
                  <FormLabel>Username</FormLabel>
                  <FormControl>
                    <Input {...field} />
                  </FormControl>
                  <FormMessage />
                </FormItem>
              )}
            />

            <FormField
              control={form.control}
              name="password"
              render={({ field }) => (
                <FormItem>
                  <FormLabel>Password</FormLabel>
                  <FormControl>
                    <Input type="password" {...field} />
                  </FormControl>
                  <FormMessage />
                </FormItem>
              )}
            />

            <FormField
              control={form.control}
              name="firstName"
              render={({ field }) => (
                <FormItem>
                  <FormLabel>First Name</FormLabel>
                  <FormControl>
                    <Input {...field} />
                  </FormControl>
                  <FormMessage />
                </FormItem>
              )}
            />

            <FormField
              control={form.control}
              name="lastName"
              render={({ field }) => (
                <FormItem>
                  <FormLabel>Last Name</FormLabel>
                  <FormControl>
                    <Input {...field} />
                  </FormControl>
                  <FormMessage />
                </FormItem>
              )}
            />

            <div className='flex flex-row items-center justify-between'>
              <Button type="submit">Register</Button>
              <Link href="/login" className='font-bold text-sm text-blue-500 hover:text-blue-800'>Login</Link>
            </div>

          </form>
        </Form>


      </div>
    </div>
  )
}

export default RegisterPage