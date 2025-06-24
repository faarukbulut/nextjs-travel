"use client"
import { useSearchParams } from 'next/navigation'
import React from 'react'

const Search = () => {

    const searchParams = useSearchParams();

    const destination = searchParams.get("destination");
    const activity = searchParams.get("activity");
    const duration = searchParams.get("duration");
    const price = searchParams.get("price");

    return (
        <div>
            
        </div>
    )
}

export default Search