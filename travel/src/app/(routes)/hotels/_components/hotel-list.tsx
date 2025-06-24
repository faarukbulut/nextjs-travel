"use client"
import React, { useEffect, useState } from 'react'
import {
  Card,
  CardAction,
  CardContent,
  CardDescription,
  CardFooter,
  CardHeader,
  CardTitle,
} from "@/components/ui/card"
import { Skeleton } from '@/components/ui/skeleton';
import { Hotel } from "@/models/hotel";

const HotelList = () => {

    const [hotels, setHotels] = useState<Hotel[]>([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(false);

    useEffect(() => {
        fetch("http://localhost:5223/api/Hotel/GetHotelList")
        .then((res) => res.json())
        .then((data: Hotel[]) => {
            setHotels(data);
            setLoading(false);
        })
        .catch((err) => {
            setError(true);
            setLoading(false);
        })
    }, []);

    return (
        <div className='container mx-auto p-4'>
            <h1 className='text-2xl font-bold mb-4'>Hotels</h1>

            {loading && (
                <div className='grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4'>
                    {Array.from({length: 6}).map((_, index) =>(
                        <Skeleton key={index} className='h-72 w-full rounded-lg' />
                    ))}
                </div>
            )}

            {error && (
                <div className='text-center text-red-500 font-semibold'>
                    Something went wrong
                </div>
            )}

            {!loading && !error &&(
                <div className='grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4'>
                    {hotels.map((hotel) => (
                        <Card key={hotel.hotelId} className='shadow-md'>
                            <CardHeader>
                                <img src={hotel.photos[0]} alt='' />
                                <CardTitle className='text-lg font-semibold mt-2'>{hotel.name}</CardTitle>
                            </CardHeader>
                            <CardContent>
                                <p className='text-gray-700'>{hotel.description}</p>
                                <p className='text-gray-700'>{hotel.location}</p>
                                <p className='text-gray-700'>{hotel.pricePerNight} / Night</p>
                            </CardContent>
                        </Card>
                    ))}
                </div>
            )}
        </div>
    )
}

export default HotelList