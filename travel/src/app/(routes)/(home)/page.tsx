import RecentProduct from "@/components/sections/recent/recent-product";
import Hero from "./_components/hero/hero";
import Banners from "./_components/banners/banners";
import Stats from "../about/_components/stats";

export default function Home() {
  return (
    <div>
      <Hero />
      <div className="min-h-24"></div>
      <Banners />
      <div className="min-h-24"></div>
      <RecentProduct />
    </div>
  );
}
