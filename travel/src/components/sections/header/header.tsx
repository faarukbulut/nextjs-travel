"use client"
import { Facebook, Instagram, MessageCircle, Phone, Twitter, User } from 'lucide-react';
import Image from 'next/image';
import Link from 'next/link';
import React from 'react'
import MobileMenu from './mobile-menu';
import { navigationLinks } from '@/constants';
import SearchPage from './search';
import { usePathname } from 'next/navigation';

const Header = () => {

    const pathName = usePathname();

    const socialLinks = [
        {href: "#", icon: <Facebook size={16} /> },
        {href: "#", icon: <Twitter size={16} /> },
        {href: "#", icon: <Instagram size={16} /> },
    ];

    return (
        <header className="bg-black text-white">

            {/** Top Bar */}
            <div className='flex container mx-auto h-16 justify-center md:justify-between items-center px-4 py-2 text-sm'>
                <div className='flex items-center gap-5'>
                    <div className='flex gap-3 items-center'>
                        <div className='bg-white p-2 rounded-fulll'>
                            <MessageCircle size={12} className='text-orange-500' />
                        </div>
                        info@travel.com
                    </div>
                    <div className='flex gap-3 items-center'>
                        <div className='bg-white p-2 rounded-full'>
                            <Phone size={12} className='text-orange-500' />
                        </div>
                        0500 500 20 20
                    </div>
                </div>
                <div className='hidden md:flex items-center space-x-4'>
                    {socialLinks.map((link, index) => (
                        <Link key={index} href={link.href} className='hover:text-orange-500'>
                            {link.icon}
                        </Link>
                    ))}
                </div>
            </div>

            {/** Navigation Bar */}
            <div className='bg-white h-18 text-black shadow flex items-center'>
                <div className='container mx-auto px-4 py-3 flex justify-between items-center'>
                    <Image src={"/logo.png"} alt="Travel" width={200} height={60} className='w-24 lg:w-38 h-auto' />
                    
                    <nav className='hidden lg:flex space-x-8 text-md font-semibold'>
                        {navigationLinks.map((link, index) => (
                            <Link key={index} href={link.href} className={`${pathName === link.href ? "text-orange-500" : "hover:text-orange-500"}`}>
                                {link.label}
                            </Link>
                        ))}
                    </nav>

                    <div className='flex item-center space-x-4'>
                        <SearchPage />
                        <div className='p-2 bg-orange-500 cursor-pointer text-white rounded-full'>
                            <User size={16}/>
                        </div>
                        <MobileMenu />
                    </div>
                </div>
            </div>
        </header>
  )
}

export default Header